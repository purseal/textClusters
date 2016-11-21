using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdProject
{
    class Parameters
    {
        /// <summary>
        /// PartOfSpeech - part of speech in filtering or of the selected word
        /// termSurPartOfSpeech - part of speech of terminological surroundings
        /// word - selected word
        /// sentNumber - sentence number of selected word
        /// dist - maximum words count between selected word and term
        /// </summary>
        public string PartOfSpeech;
        public string termSurPartOfSpeech;
        public string sentNumber;
        public string word;
        public string radius;
    }
}
