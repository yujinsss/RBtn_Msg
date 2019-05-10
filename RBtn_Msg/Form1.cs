using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RBtn_Msg
{
    public partial class Form1 : Form
    {
        MessageBoxButtons mbb;  // 메시지 버튼 옵션 설정 
        MessageBoxIcon mbi;     // 메시지 버튼 아이콘 설정

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbOk.Checked)
                this.mbb = MessageBoxButtons.OK;     // [확인] 버튼
            else if (this.rbOkCancel.Checked)
               this.mbb = MessageBoxButtons.OKCancel;// [확인/취소] 버튼
            else if (this.rbYesNo.Checked)
                this.mbb = MessageBoxButtons.YesNo;  // [예/아니오] 버튼

            if (this.rbError.Checked)
                this.mbi = MessageBoxIcon.Error;         // 에러 아이콘
            else if (this.rbInformation.Checked)
                this.mbi = MessageBoxIcon.Information;   // 정보 아이콘
            else if (this.rbQuestion.Checked)
                mbi = MessageBoxIcon.Question;      // 질문 아이콘

            MessageBox.Show("메시지 박스를 확인하세요", "알림", mbb, mbi);

        }
    }
}
