namespace ECOLAB.IOT.Transmit
{
    using System;

    public class TrackerMessageBox : EventArgs
    {
        private string text;
        private string caption;

        private readonly ReceviedMessageBoxButtons messageBoxButtons;
        private readonly ReceviedMessageBoxIcon messageBoxIcon;

        public TrackerMessageBox(string text, string caption, ReceviedMessageBoxButtons messageBoxButtons= ReceviedMessageBoxButtons.OK,
            ReceviedMessageBoxIcon messageBoxIcon = ReceviedMessageBoxIcon.Information)
        {
            this.text = text;
            this.caption = caption;
            this.messageBoxButtons = messageBoxButtons;
            this.messageBoxIcon = messageBoxIcon;
        }
       
        public ReceviedMessageBoxButtons MessageBoxButtons
        {
            get { return messageBoxButtons; }
        }
        public ReceviedMessageBoxIcon MessageBoxIcon
        {
            get { return messageBoxIcon; }
        }

        public string Text
        {
            get
            {
                return text;
            }
        }

        public string Caption
        {
            get
            {
                return caption;
            }
        }
    }
    public class ReceivedMessageBox
    {

        public ReceivedMessageBox(string message, bool transform = false)
        {
            this.message = message;
            this.transform = transform;
        }
        private string message;
        private readonly bool transform = false;
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public bool TransForm
        {
            get { return transform; }
        }
    }
    //
    // 摘要:
    //     Specifies constants defining which buttons to display on a System.Windows.Forms.MessageBox.
    public enum ReceviedMessageBoxButtons
    {
        //
        // 摘要:
        //     The message box contains an OK button.
        OK = 0,
        //
        // 摘要:
        //     The message box contains OK and Cancel buttons.
        OKCancel = 1,
        //
        // 摘要:
        //     The message box contains Abort, Retry, and Ignore buttons.
        AbortRetryIgnore = 2,
        //
        // 摘要:
        //     The message box contains Yes, No, and Cancel buttons.
        YesNoCancel = 3,
        //
        // 摘要:
        //     The message box contains Yes and No buttons.
        YesNo = 4,
        //
        // 摘要:
        //     The message box contains Retry and Cancel buttons.
        RetryCancel = 5,
        //
        // 摘要:
        //     Specifies that the message box contains Cancel, Try Again, and Continue buttons.
        CancelTryContinue = 6
    }
    //
    // 摘要:
    //     Specifies constants defining which information to display.
    public enum ReceviedMessageBoxIcon
    {
        //
        // 摘要:
        //     The message box contains no symbols.
        None = 0,
        //
        // 摘要:
        //     The message box contains a symbol consisting of a white X in a circle with a
        //     red background.
        Hand = 16,
        //
        // 摘要:
        //     The message box contains a symbol consisting of white X in a circle with a red
        //     background.
        Stop = 16,
        //
        // 摘要:
        //     The message box contains a symbol consisting of white X in a circle with a red
        //     background.
        Error = 16,
        //
        // 摘要:
        //     The message box contains a symbol consisting of a question mark in a circle.
        //     The question mark message icon is no longer recommended because it does not clearly
        //     represent a specific type of message and because the phrasing of a message as
        //     a question could apply to any message type. In addition, users can confuse the
        //     question mark symbol with a help information symbol. Therefore, do not use this
        //     question mark symbol in your message boxes. The system continues to support its
        //     inclusion only for backward compatibility.
        Question = 32,
        //
        // 摘要:
        //     The message box contains a symbol consisting of an exclamation point in a triangle
        //     with a yellow background.
        Exclamation = 48,
        //
        // 摘要:
        //     The message box contains a symbol consisting of an exclamation point in a triangle
        //     with a yellow background.
        Warning = 48,
        //
        // 摘要:
        //     The message box contains a symbol consisting of a lowercase letter i in a circle.
        Asterisk = 64,
        //
        // 摘要:
        //     The message box contains a symbol consisting of a lowercase letter i in a circle.
        Information = 64
    }
}
