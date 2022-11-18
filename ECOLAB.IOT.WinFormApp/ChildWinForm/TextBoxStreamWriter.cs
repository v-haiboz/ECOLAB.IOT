
namespace ECOLAB.IOT.WinFormApp.ChildWinForm
{
    using System.Text;

    public class TextBoxStreamWriter: TextWriter
    {
        RichTextBox _output = null;

        public TextBoxStreamWriter(RichTextBox output)
        {
            _output = output;
        }

        public override void Write(char value)
        {
            base.Write(value);
            _output.AppendText(value.ToString()); // When character data is written, append it to the text box.
            _output.Refresh();
        }

        public override Encoding Encoding
        {
            get { return Encoding.UTF8; }
        }
    }
}
