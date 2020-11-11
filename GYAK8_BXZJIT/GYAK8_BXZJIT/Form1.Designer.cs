namespace GYAK8_BXZJIT
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.Car = new System.Windows.Forms.Button();
            this.ball = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.present = new System.Windows.Forms.Button();
            this.box = new System.Windows.Forms.Button();
            this.ribbon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(13, 170);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(775, 205);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // Car
            // 
            this.Car.Location = new System.Drawing.Point(36, 23);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(75, 23);
            this.Car.TabIndex = 1;
            this.Car.Text = "Car";
            this.Car.UseVisualStyleBackColor = true;
            this.Car.Click += new System.EventHandler(this.Car_Click);
            // 
            // ball
            // 
            this.ball.Location = new System.Drawing.Point(162, 23);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(75, 23);
            this.ball.TabIndex = 2;
            this.ball.Text = "Ball";
            this.ball.UseVisualStyleBackColor = true;
            this.ball.Click += new System.EventHandler(this.ball_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Coming next";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(437, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // present
            // 
            this.present.Location = new System.Drawing.Point(551, 35);
            this.present.Name = "present";
            this.present.Size = new System.Drawing.Size(75, 23);
            this.present.TabIndex = 5;
            this.present.Text = "Present";
            this.present.UseVisualStyleBackColor = true;
            this.present.Click += new System.EventHandler(this.present_Click);
            // 
            // box
            // 
            this.box.BackColor = System.Drawing.Color.Red;
            this.box.Location = new System.Drawing.Point(551, 77);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(75, 23);
            this.box.TabIndex = 6;
            this.box.UseVisualStyleBackColor = false;
            this.box.Click += new System.EventHandler(this.button1_Click);
            // 
            // ribbon
            // 
            this.ribbon.BackColor = System.Drawing.Color.Lime;
            this.ribbon.Location = new System.Drawing.Point(551, 106);
            this.ribbon.Name = "ribbon";
            this.ribbon.Size = new System.Drawing.Size(75, 23);
            this.ribbon.TabIndex = 7;
            this.ribbon.UseVisualStyleBackColor = false;
            this.ribbon.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ribbon);
            this.Controls.Add(this.box);
            this.Controls.Add(this.present);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button Car;
        private System.Windows.Forms.Button ball;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button present;
        private System.Windows.Forms.Button box;
        private System.Windows.Forms.Button ribbon;
    }
}

