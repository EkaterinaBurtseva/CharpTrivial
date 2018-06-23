using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*There is an enumerator Person, that contains English names of heroes of Norse myths(Loki, Thor, Freyja, Sigyn, ...). 
Translations of these names are stored in XML file and contains names of same gods but in Norwegian(Loke, Tor, Frøya, Sigyn, ...).
Input of function is textWithNames string, primaryDictionary<string, Person> and secondaryDictionary<string, 
   Person>.Output should contain the textWithNames string where all keyword present in primaryDictionary should be replaced 
   with corresponding translations of Person enum value.If string keyword of primaryDictionary is present in secondaryDictionary
   it should be replaced with value from secondaryDictionary.

   Example: We have textWithNames="Evil genius god of Chaos jumps over the lazy God of thunder.". There is primaryDictionary={{"god of chaos", Loki}, {"god of thunder", Odin}} 
   and secondaryDictionary={{{"god of thunder", Thor}}. The output should be "Evil genius Loke jumps over the lazy Tor."
   */
namespace Collection_tasks
{
    class Norse
    {
    }
}
