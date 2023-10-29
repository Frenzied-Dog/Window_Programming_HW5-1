namespace hw5_1_10_20 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            StartBtn = new Button();
            StateLabel = new Label();
            CountDownLabel = new Label();
            CdTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // StartBtn
            // 
            StartBtn.BackColor = Color.White;
            StartBtn.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            StartBtn.Location = new Point(285, 300);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(230, 45);
            StartBtn.TabIndex = 0;
            StartBtn.Text = "開始遊戲";
            StartBtn.UseVisualStyleBackColor = false;
            StartBtn.Click += StartBtn_Click;
            // 
            // StateLabel
            // 
            StateLabel.AutoSize = true;
            StateLabel.Font = new Font("Microsoft JhengHei UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            StateLabel.Location = new Point(332, 35);
            StateLabel.Name = "StateLabel";
            StateLabel.Size = new Size(0, 38);
            StateLabel.TabIndex = 1;
            StateLabel.Visible = false;
            // 
            // CountDownLabel
            // 
            CountDownLabel.AutoSize = true;
            CountDownLabel.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CountDownLabel.Location = new Point(385, 90);
            CountDownLabel.Name = "CountDownLabel";
            CountDownLabel.Size = new Size(0, 35);
            CountDownLabel.TabIndex = 2;
            CountDownLabel.Visible = false;
            // 
            // CdTimer
            // 
            CdTimer.Interval = 1000;
            CdTimer.Tick += CdTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(CountDownLabel);
            Controls.Add(StateLabel);
            Controls.Add(StartBtn);
            KeyPreview = true;
            Name = "Form1";
            Text = "記憶小遊戲";
            KeyPress += Form1_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartBtn;
        private Label StateLabel;
        private Label CountDownLabel;
        private System.Windows.Forms.Timer CdTimer;
    }
}