
namespace ECOLAB.IOT.WinFormApp.ChildWinForm
{
    using ECOLAB.IOT.Service;
    using ECOLAB.IOT.Transmit;
    using System.Text;
    using System.Windows.Forms;

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
            _output.AppendText(value.ToString()); 
            _output.Refresh();
            Utility.Track(value.ToString());
        }

        public override Encoding Encoding
        {
            get { return Encoding.UTF8; }
        }
    }
}
