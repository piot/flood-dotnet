/*----------------------------------------------------------------------------------------------------------
 *  Copyright (c) Peter Bjorklund. All rights reserved. https://github.com/piot/flood-dotnet
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------------------*/

namespace Piot.Flood
{
    public interface IOctetReaderWithSkip : IOctetReader, ISkip
    {
    }

    public interface IOctetReaderWithSeekAndSkip : IOctetReader, ISkip, ISeekable
    {
        void Dispose();
    }
}