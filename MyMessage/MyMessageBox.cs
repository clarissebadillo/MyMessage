using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMessage
{
    public static class MyMessageBox
    {
        public static System.Windows.Forms.DialogResult ShowMessage(string message, string caption, System.Windows.Forms.MessageBoxButtons button, System.Windows.Forms.MessageBoxIcon icon)
        {
            System.Windows.Forms.DialogResult dlgResult = System.Windows.Forms.DialogResult.None;
            switch (button)
            {
                case System.Windows.Forms.MessageBoxButtons.OK:
                    using (frmMessageOK msgOK = new frmMessageOK())
                    {
                        msgOK.Text = caption;
                        msgOK.Message = message;
                        switch (icon)
                        { 
                            case System.Windows.Forms.MessageBoxIcon.Information:
                            msgOK.MessageIcon = MyMessage.Properties.Resources.icon_success;
                            break;
                        case System.Windows.Forms.MessageBoxIcon.Question:
                            msgOK.MessageIcon = MyMessage.Properties.Resources.question_icon;
                            break;
                        case System.Windows.Forms.MessageBoxIcon.Error:
                            msgOK.MessageIcon = MyMessage.Properties.Resources.error_icon;
                            break;
                        case System.Windows.Forms.MessageBoxIcon.Warning:
                            msgOK.MessageIcon = MyMessage.Properties.Resources.warning_icon;
                            break;
                        }
                        dlgResult = msgOK.ShowDialog();
                    }
                    break;

                case System.Windows.Forms.MessageBoxButtons.YesNo:
                    using (frmMessageYesNo msgYesNo = new frmMessageYesNo())
                    {
                        msgYesNo.Text = caption;
                        msgYesNo.Message = message;
                        switch (icon)
                        { 
                            case System.Windows.Forms.MessageBoxIcon.Information:
                            msgYesNo.MessageIcon = MyMessage.Properties.Resources.icon_success;
                            break;
                        case System.Windows.Forms.MessageBoxIcon.Question:
                            msgYesNo.MessageIcon = MyMessage.Properties.Resources.question_icon;
                            break;
                            case System.Windows.Forms.MessageBoxIcon.Error:
                                msgYesNo.MessageIcon = MyMessage.Properties.Resources.error_icon;
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Warning:
                                msgYesNo.MessageIcon = MyMessage.Properties.Resources.warning_icon;
                                break;
                        }
                        dlgResult = msgYesNo.ShowDialog();
                    }
                    break;

                case System.Windows.Forms.MessageBoxButtons.RetryCancel:
                    using (frmMessageError msgError = new frmMessageError())
                    {
                        msgError.Text = caption;
                        msgError.Message = message;
                        switch (icon)
                        {
                            case System.Windows.Forms.MessageBoxIcon.Information:
                                msgError.MessageIcon = MyMessage.Properties.Resources.icon_success;
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Question:
                                msgError.MessageIcon = MyMessage.Properties.Resources.question_icon;
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Warning:
                                msgError.MessageIcon = MyMessage.Properties.Resources.warning_icon;
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Error:
                                msgError.MessageIcon = MyMessage.Properties.Resources.error_icon;
                                break;
                        }
                        dlgResult = msgError.ShowDialog();
                    }
                    break;


                case System.Windows.Forms.MessageBoxButtons.OKCancel:
                    using (frmMessageOKCancel msgOKCancel = new frmMessageOKCancel())
                    {
                        msgOKCancel.Text = caption;
                        msgOKCancel.Message = message;
                        switch (icon)
                        {
                            case System.Windows.Forms.MessageBoxIcon.Information:
                                msgOKCancel.MessageIcon = MyMessage.Properties.Resources.icon_success;
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Question:
                                msgOKCancel.MessageIcon = MyMessage.Properties.Resources.question_icon;
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Warning:
                                msgOKCancel.MessageIcon = MyMessage.Properties.Resources.warning_icon;
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Error:
                                msgOKCancel.MessageIcon = MyMessage.Properties.Resources.error_icon;
                                break;
                        }
                        dlgResult = msgOKCancel.ShowDialog();
                    }
                    break;
            }
            return dlgResult;
        }
    }
}
