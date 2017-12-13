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
    // This class is to store data. 
    class TrumpiaData
    {
        public string timeStamp { get; set; }
        public string pushID { get; set; }
        public string inboundID { get; set; }
        public string subscriptionUid { get; set; }
        public string phoneNumber { get; set; }
        public string contents { get; set; }
        public string keyword { get; set; }
        public string dataCapture { get; set; }
        public string attachment { get; set; }
        public string datasetID { get; set; }
        public string datasetName { get; set; }
    }
}
