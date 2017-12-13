/* This file is part of Inbound Sample.

The Inbound Sample is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

The Inbound Sample is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with The Inbound.  If not, see <http://www.gnu.org/licenses/>.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inbound_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Inbound inbound = new Inbound();

            // example xml string
            inbound.Execute("<?xml version=\"1.0\" encoding=\"UTF-8\" ?><TRUMPIA><PUSH_ID>289054852</PUSH_ID><INBOUND_ID>66076129</INBOUND_ID><SUBSCRIPTION_UID>229874806</SUBSCRIPTION_UID><PHONENUMBER>7142223337</PHONENUMBER><KEYWORD>paulkim2</KEYWORD><DATA_CAPTURE /><CONTENTS /><ATTACHMENT /><DATASET_ID>0</DATASET_ID><DATASET_NAME>Master Account</DATASET_NAME></TRUMPIA>");
        }
    }
}
