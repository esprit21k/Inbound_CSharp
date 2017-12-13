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

 * Program Work Flow
 * 1. Receive xml message as a String.
 * 2. Check form, retrieve parameters.
 * 3. Write parameters in CSV log file.
 *
 */
using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Inbound_CSharp
{
    class Inbound
    {

        TrumpiaData trum = new TrumpiaData();
        public void Execute(string inboundXml)
        {
            XDocument xml = XDocument.Parse(inboundXml);

            if (String.IsNullOrEmpty(xml.Element("TRUMPIA").ToString()))
            {
                return;
            }
            Parse(xml.Document);
            WriteLog();
        }

        // This function get parameters from xml and store in TrumpiaData.
        private void Parse(XDocument xml)
        {
            trum.timeStamp = IndivisualParse(xml, trum.timeStamp, "TIME_STAMP");
            trum.pushID = IndivisualParse(xml, trum.pushID, "PUSH_ID");
            trum.inboundID = IndivisualParse(xml, trum.inboundID, "INBOUND_ID");
            trum.subscriptionUid = IndivisualParse(xml, trum.subscriptionUid, "SUBSCRIPTION_UID");
            trum.phoneNumber = IndivisualParse(xml, trum.phoneNumber, "PHONENUMBER");
            trum.keyword = IndivisualParse(xml, trum.keyword, "KEYWORD");
            trum.dataCapture = IndivisualParse(xml, trum.dataCapture, "DATACAPTURE");
            trum.contents = IndivisualParse(xml, trum.contents, "CONTENTS");
            trum.attachment = IndivisualParse(xml, trum.attachment, "ATTACHMENT");
            trum.datasetID = IndivisualParse(xml, trum.datasetID, "DATASET_ID");
        }

        // This function parse indivisual xml parameter.
        private String IndivisualParse(XDocument xml, string parameter, string path)
        {
            try
            {
                return xml.Element("TRUMPIA").Element(path).Value;
            }
            catch(Exception e)
            {
                return null;
            }
        }

        // This function writes parameters in csv log file.
        private void WriteLog()
        {
            StreamWriter sw = new StreamWriter("c:/documents/TrumpiaLog.csv", true);
            sw.WriteLine("{0},{1}","SUBSCRIPTION_UID,", trum.subscriptionUid);
            sw.WriteLine("{0},{1}", "PHONENUMBER,", trum.phoneNumber);
            sw.WriteLine("{0},{1}", "KEYWORD,", trum.keyword);
            sw.WriteLine("{0},{1}", "CONTENTS,", trum.contents);
            sw.Close();
        }
    }
}
