﻿/*
 *  Copyright 2012-2016 The Asn1Net Project
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */
/*
 *  Written for the Asn1Net project by:
 *  Peter Polacko <peter.polacko+asn1net@gmail.com>
 */

using System.IO;
using System.Linq;
using Net.Asn1.Type;
using Xunit;

namespace Net.Asn1.Writer.Tests
{
    public partial class DerWriterTests
    {
        [InlineData("01 01 FF", true)]
        [InlineData("01 01 00", false)]
        [Theory]
        public void WriteBoolean(string correctResultHex, bool valueToTest)
        {
            var encoded = Helpers.GetExampleBytes(correctResultHex);
            using (var ms = new MemoryStream())
            {
                var asn1Bool = new Asn1Boolean(valueToTest);

                new DerWriter(ms).Write(asn1Bool);

                var res = Enumerable.SequenceEqual(encoded, ms.ToArray());
                Assert.True(res);
            }
        }
    }
}
