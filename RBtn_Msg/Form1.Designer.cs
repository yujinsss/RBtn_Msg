﻿namespace RBtn_Msg
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpOption1 = new System.Windows.Forms.GroupBox();
            this.gpOption2 = new System.Windows.Forms.GroupBox();
            this.rbYesNo = new System.Windows.Forms.RadioButton();
            this.rbOkCancel = new System.Windows.Forms.RadioButton();
            this.rbOk = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbError = new System.Windows.Forms.RadioButton();
            this.rbInformation = new System.Windows.Forms.RadioButton();
            this.rbQuestion = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.gpOption1.SuspendLayout();
            this.gpOption2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpOption1
            // 
            this.gpOption1.Controls.Add(this.rbYesNo);
            this.gpOption1.Controls.Add(this.rbOkCancel);
            this.gpOption1.Controls.Add(this.rbOk);
            this.gpOption1.Location = new System.Drawing.Point(13, 13);
            this.gpOption1.Name = "gpOption1";
            this.gpOption1.Size = new System.Drawing.Size(126, 120);
            this.gpOption1.TabIndex = 0;
            this.gpOption1.TabStop = false;
            this.gpOption1.Text = "Type";
            // 
            // gpOption2
            // 
            this.gpOption2.Controls.Add(this.rbError);
            this.gpOption2.Controls.Add(this.groupBox3);
            this.gpOption2.Controls.Add(this.rbInformation);
            this.gpOption2.Controls.Add(this.rbQuestion);
            this.gpOption2.Location = new System.Drawing.Point(145, 13);
            this.gpOption2.Name = "gpOption2";
            this.gpOption2.Size = new System.Drawing.Size(126, 120);
            this.gpOption2.TabIndex = 1;
            this.gpOption2.TabStop = false;
            this.gpOption2.Text = "Icon";
            // 
            // rbYesNo
            // 
            this.rbYesNo.AutoSize = true;
            this.rbYesNo.Location = new System.Drawing.Point(6, 68);
            this.rbYesNo.Name = "rbYesNo";
            this.rbYesNo.Size = new System.Drawing.Size(61, 16);
            this.rbYesNo.TabIndex = 4;
            this.rbYesNo.TabStop = true;
            this.rbYesNo.Text = "YesNo";
            this.rbYesNo.UseVisualStyleBackColor = true;
            // 
            // rbOkCancel
            // 
            this.rbOkCancel.AutoSize = true;
            this.rbOkCancel.Location = new System.Drawing.Point(6, 45);
            this.rbOkCancel.Name = "rbOkCancel";
            this.rbOkCancel.Size = new System.Drawing.Size(78, 16);
            this.rbOkCancel.TabIndex = 3;
            this.rbOkCancel.TabStop = true;
            this.rbOkCancel.Text = "OkCancel";
            this.rbOkCancel.UseVisualStyleBackColor = true;
            // 
            // rbOk
            // 
            this.rbOk.AutoSize = true;
            this.rbOk.Location = new System.Drawing.Point(6, 22);
            this.rbOk.Name = "rbOk";
            this.rbOk.Size = new System.Drawing.Size(38, 16);
            this.rbOk.TabIndex = 2;
            this.rbOk.TabStop = true;
            this.rbOk.Text = "Ok";
            this.rbOk.UseVisualStyleBackColor = true;
            this.rbOk.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(132, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(126, 141);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // rbError
            // 
            this.rbError.AutoSize = true;
            this.rbError.Location = new System.Drawing.Point(6, 24);
            this.rbError.Name = "rbError";
            this.rbError.Size = new System.Drawing.Size(50, 16);
            this.rbError.TabIndex = 7;
            this.rbError.TabStop = true;
            this.rbError.Text = "Error";
            this.rbError.UseVisualStyleBackColor = true;
            // 
            // rbInformation
            // 
            this.rbInformation.AutoSize = true;
            this.rbInformation.Location = new System.Drawing.Point(6, 46);
            this.rbInformation.Name = "rbInformation";
            this.rbInformation.Size = new System.Drawing.Size(85, 16);
            this.rbInformation.TabIndex = 6;
            this.rbInformation.TabStop = true;
            this.rbInformation.Text = "Information";
            this.rbInformation.UseVisualStyleBackColor = true;
            // 
            // rbQuestion
            // 
            this.rbQuestion.AutoSize = true;
            this.rbQuestion.Location = new System.Drawing.Point(6, 68);
            this.rbQuestion.Name = "rbQuestion";
            this.rbQuestion.Size = new System.Drawing.Size(73, 16);
            this.rbQuestion.TabIndex = 5;
            this.rbQuestion.TabStop = true;
            this.rbQuestion.Text = "Question";
            this.rbQuestion.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("양재깨비체B", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnShow.Location = new System.Drawing.Point(13, 139);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(258, 52);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 204);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.gpOption2);
            this.Controls.Add(this.gpOption1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "메시지 박스 보기";
            this.gpOption1.ResumeLayout(false);
            this.gpOption1.PerformLayout();
            this.gpOption2.ResumeLayout(false);
            this.gpOption2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpOption1;
        private System.Windows.Forms.GroupBox gpOption2;
        private System.Windows.Forms.RadioButton rbYesNo;
        private System.Windows.Forms.RadioButton rbOkCancel;
        private System.Windows.Forms.RadioButton rbOk;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbError;
        private System.Windows.Forms.RadioButton rbInformation;
        private System.Windows.Forms.RadioButton rbQuestion;
        private System.Windows.Forms.Button btnShow;
    }
}

