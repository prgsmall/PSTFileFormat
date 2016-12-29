/* Copyright (C) 2012-2016 ROM Knowledgeware. All rights reserved.
 * 
 * You can redistribute this program and/or modify it under the terms of
 * the GNU Lesser Public License as published by the Free Software Foundation,
 * either version 3 of the License, or (at your option) any later version.
 * 
 * Maintainer: Tal Aloni <tal@kmrom.com>
 */
using System;
using System.Collections.Generic;
using System.Text;
using Utilities;

namespace PSTFileFormat
{
    // SUD_FLD_MOD / SUD_FLD_DEL
    public class SearchUpdateDescriptorFolderModified : SearchUpdateDescriptorData
    {
        public NodeID nidFld;

        public SearchUpdateDescriptorFolderModified(NodeID folderNodeID)
        {
            nidFld = folderNodeID;
        }

        public SearchUpdateDescriptorFolderModified(byte[] buffer, int offset)
        {
            nidFld = new NodeID(buffer, offset + 0);
        }

        public override void WriteBytes(byte[] buffer, int offset)
        {
            LittleEndianWriter.WriteUInt32(buffer, offset + 0, nidFld.Value);
        }
    }
}