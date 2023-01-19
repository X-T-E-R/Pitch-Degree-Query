using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using key.Utilities;
namespace key
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cboKey.Items.AddRange(_converters._noteNames);
            cboKey.SelectedIndex = 0;
        }
        Converters _converters = new Converters();
        private void keyChange()
        {
            // Get the key name from the TextBox
            var keyName = cboKey.SelectedItem.ToString();
            // Get the note number of the key
            var keyNoteNumber = _converters.NoteNameToNumber(keyName);
            // Clear the ListBox
            lstNotes.Items.Clear();

            // Iterate through the degrees and add the note name to the ListBox
            foreach (var degree in _converters._noteDegree.Values)
            {
                var degreeNumber = _converters.DegreeToNoteNumber(degree);
                var noteNumber = (degreeNumber - 1 + keyNoteNumber - 1) % 12 + 1;
                var noteName = _converters.NoteNumberToFullName(noteNumber);
                lstNotes.Items.Add($"{degree} : {noteName}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cboKey_SelectedValueChanged(object sender, EventArgs e)
        {
            keyChange();
        }
    }
}
