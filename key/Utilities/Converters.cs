using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace key.Utilities
{
    public class Converters
    {
        private readonly Dictionary<string, int> _noteAliases = new Dictionary<string, int>
    {
        {"C", 1},
        {"C#", 2},
        {"Db", 2},
        {"D", 3},
        {"D#", 4},
        {"Eb", 4},
        {"E", 5},
        {"F", 6},
        {"F#", 7},
        {"Gb", 7},
        {"G", 8},
        {"G#", 9},
        {"Ab", 9},
        {"A", 10},
        {"A#", 11},
        {"Bb", 11},
        {"B", 12},
    };
        public readonly string[] _noteNames = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

        public readonly Dictionary<int, string> _noteDegree = new Dictionary<int, string>
    {
        {1, "I"},
        {3, "II"},
        {5, "III"},
        {6, "IV"},
        {8, "V"},
        {10, "VI"},
        {12, "VII"}
    };
        public static readonly string[] _degrees = new string[] { "I", "II", "III", "IV", "V", "VI", "VII" };
        public int NoteNameToNumber(string noteName)
        {
            if (_noteAliases.TryGetValue(noteName, out int noteNumber))
            {
                return noteNumber;
            }
            throw new ArgumentException("Invalid note name.");
        }

        public string NoteNumberToName(int noteNumber)
        {
            if (noteNumber >= 1 && noteNumber <= 12)
            {
                return _noteNames[noteNumber - 1];
            }
            throw new ArgumentOutOfRangeException("Invalid note number.");
        }
        public string NoteNumberToFullName(int noteNumber)
        {
            if (noteNumber < 1 || noteNumber > 12)
            {
                throw new ArgumentOutOfRangeException("Invalid note number.");
            }
            var noteName = _noteNames[noteNumber - 1];
            var noteAliases = _noteAliases.Where(x => x.Value == noteNumber).Select(x => x.Key);
            return $"{string.Join("/", noteAliases)}";
        }

        public string NoteNumberToDegree(int noteNumber)
        {
            if (_noteDegree.TryGetValue(noteNumber, out var degree))
            {
                return degree;
            }
            throw new ArgumentOutOfRangeException("Invalid note number.");
        }
        public int DegreeToNoteNumber(string degree)
        {
            var inverseNoteDegree = _noteDegree.ToDictionary(x => x.Value, x => x.Key);
            if (inverseNoteDegree.TryGetValue(degree, out int noteNumber))
            {
                return noteNumber;
            }
            throw new ArgumentException("Invalid degree name.");
        }

    }
}
