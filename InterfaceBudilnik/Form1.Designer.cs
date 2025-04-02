namespace InterfaceBudilnik
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBackground = new System.Windows.Forms.Panel();
            this.labelbst = new System.Windows.Forms.Label();
            this.dtpAlarmTime = new System.Windows.Forms.DateTimePicker();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.btnSnooze = new System.Windows.Forms.Button();
            this.btnStopAlarm = new System.Windows.Forms.Button();
            this.btnSetAlarm = new System.Windows.Forms.Button();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.labelbst);
            this.panelBackground.Controls.Add(this.dtpAlarmTime);
            this.panelBackground.Controls.Add(this.lblCurrentTime);
            this.panelBackground.Controls.Add(this.btnSnooze);
            this.panelBackground.Controls.Add(this.btnStopAlarm);
            this.panelBackground.Controls.Add(this.btnSetAlarm);
            this.panelBackground.Location = new System.Drawing.Point(-2, -3);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(678, 387);
            this.panelBackground.TabIndex = 2;
            // 
            // labelbst
            // 
            this.labelbst.AutoSize = true;
            this.labelbst.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelbst.Location = new System.Drawing.Point(178, 227);
            this.labelbst.Name = "labelbst";
            this.labelbst.Size = new System.Drawing.Size(0, 44);
            this.labelbst.TabIndex = 5;
            // 
            // dtpAlarmTime
            // 
            this.dtpAlarmTime.CalendarTrailingForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtpAlarmTime.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpAlarmTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpAlarmTime.Location = new System.Drawing.Point(207, 139);
            this.dtpAlarmTime.Name = "dtpAlarmTime";
            this.dtpAlarmTime.Size = new System.Drawing.Size(244, 66);
            this.dtpAlarmTime.TabIndex = 4;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentTime.Location = new System.Drawing.Point(160, 29);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(130, 44);
            this.lblCurrentTime.TabIndex = 3;
            this.lblCurrentTime.Text = "label1";
            // 
            // btnSnooze
            // 
            this.btnSnooze.BackColor = System.Drawing.Color.White;
            this.btnSnooze.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSnooze.Location = new System.Drawing.Point(398, 274);
            this.btnSnooze.Name = "btnSnooze";
            this.btnSnooze.Size = new System.Drawing.Size(224, 92);
            this.btnSnooze.TabIndex = 2;
            this.btnSnooze.Text = "Отложить будильник";
            this.btnSnooze.UseVisualStyleBackColor = false;
            this.btnSnooze.Visible = false;
            // 
            // btnStopAlarm
            // 
            this.btnStopAlarm.BackColor = System.Drawing.Color.White;
            this.btnStopAlarm.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStopAlarm.Location = new System.Drawing.Point(39, 274);
            this.btnStopAlarm.Name = "btnStopAlarm";
            this.btnStopAlarm.Size = new System.Drawing.Size(224, 92);
            this.btnStopAlarm.TabIndex = 1;
            this.btnStopAlarm.Text = "Остановить будильник";
            this.btnStopAlarm.UseVisualStyleBackColor = false;
            this.btnStopAlarm.Visible = false;
            // 
            // btnSetAlarm
            // 
            this.btnSetAlarm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSetAlarm.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetAlarm.Location = new System.Drawing.Point(218, 274);
            this.btnSetAlarm.Name = "btnSetAlarm";
            this.btnSetAlarm.Size = new System.Drawing.Size(224, 92);
            this.btnSetAlarm.TabIndex = 0;
            this.btnSetAlarm.Text = "Установить будильник";
            this.btnSetAlarm.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 381);
            this.Controls.Add(this.panelBackground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Label labelbst;
        private System.Windows.Forms.DateTimePicker dtpAlarmTime;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Button btnSnooze;
        private System.Windows.Forms.Button btnStopAlarm;
        private System.Windows.Forms.Button btnSetAlarm;
    }
}

