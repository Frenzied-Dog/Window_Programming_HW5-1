using System.Windows.Forms;

namespace hw5_1_10_20 {
    public partial class Form1 : System.Windows.Forms.Form {
        Button[] KeyPads = new Button[36];
        HashSet<int> target = new();
        HashSet<int> guess = new();
        int state = 0, cd = 4;
        Random rnd = new Random();

        public Form1() {
            InitializeComponent();
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 12; j++) {
                    int index = 12 * i + j;
                    KeyPads[index] = new Button {
                        AutoSize = true,
                        Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point),
                        Location = new Point(40 + 60 * j, 160 + 80 * i),
                        Size = new Size(50, 50),
                        TabIndex = index,
                        TabStop = true,
                        Text = index < 10 ? $"{index}" : $"{Convert.ToChar(index - 10 + 'A')}",
                        Name = $"Btn{index}",
                        Visible = false,
                        UseVisualStyleBackColor = true,
                    };
                    Controls.Add(KeyPads[index]);
                }
            }
        }

        private void StartBtn_Click(object sender, EventArgs e) {
            StartBtn.Visible = false;
            state++;
            while (target.Count < 3) {
                int t = rnd.Next(36);
                if (!target.Contains(t)) {
                    target.Add(t);
                }
            }

            StateLabel.Text = "準備階段";
            StateLabel.Visible = true;
            CountDownLabel.Visible = true;
            foreach (Button b in KeyPads) b.Visible = true;
            foreach (int i in target) KeyPads[i].BackColor = Color.PaleGreen;
            cd = 4;
            CountDownLabel.Text = "5";
            CdTimer.Start();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e) {
            if (state != 2) return;
            char input = Char.ToUpper(e.KeyChar);
            if (Char.IsDigit(input)) {
                KeyPads[input - '0'].BackColor = Color.SkyBlue;
                guess.Add(input - '0');
            } else if (Char.IsLetter(input)) {
                KeyPads[input - 'A' + 10].BackColor = Color.SkyBlue;
                guess.Add(input - 'A' + 10);
            }
        }

        private void CdTimer_Tick(object sender, EventArgs e) {
            CountDownLabel.Text = cd.ToString();
            if (cd == 0) {
                if (state == 1) {
                    state++;
                    StateLabel.Text = "玩家階段";
                    foreach (Button b in KeyPads) b.BackColor = Color.White;
                    CountDownLabel.Text = "5";
                    cd = 5;
                } else if (state == 2) {
                    state++;
                    foreach (int i in guess)
                        KeyPads[i].BackColor = target.Contains(i) ? Color.PaleGreen : Color.LightCoral;
                    foreach (int i in target)
                        KeyPads[i].BackColor = guess.Contains(i) ? Color.PaleGreen : Color.LightCoral;

                    CdTimer.Stop();
                    if (guess.SetEquals(target)) {
                        MessageBox.Show("You Win!");
                    } else {
                        MessageBox.Show("You Lose!\nTry again!");
                    }
                    state = 0;
                    foreach (Button b in KeyPads) {
                        b.BackColor = Color.White;
                        b.Visible = false;
                        StateLabel.Visible = false;
                        CountDownLabel.Visible = false;
                        StartBtn.Visible = true;
                    }
                    guess.Clear(); target.Clear();
                }
            }
            cd--;
        }
    }
}