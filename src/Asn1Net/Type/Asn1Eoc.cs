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

namespace Net.Asn1.Type
{
    /// <summary>
    /// Implementation of ASN.1 EOC
    /// </summary>
    public class Asn1Eoc : Asn1ObjectBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Asn1Eoc"/> class.
        /// </summary>
        public Asn1Eoc()
            : base(Asn1Class.Universal, false, (int)Asn1Type.Eoc)
        {
        }

        /// <inheritdoc/>
        public override byte[] Write()
        {
            return new byte[] { 0x00, 0x00 };
        }
    }
}
