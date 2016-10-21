using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoesBurgerStore.Dependencies
{
    public interface ITextToSpeech
    {
        void Read(string text);
    }
}
