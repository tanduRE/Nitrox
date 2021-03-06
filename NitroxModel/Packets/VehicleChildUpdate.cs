﻿using ProtoBufNet;
using System;
using System.Collections.Generic;
using NitroxModel.DataStructures.GameLogic;

namespace NitroxModel.Packets
{
    [Serializable]
    [ProtoContract]
    public class VehicleChildUpdate : Packet
    {
        [ProtoMember(1)]
        public string VehicleGuid { get; }

        [ProtoMember(2)]
        public List<InteractiveChildObjectIdentifier> InteractiveChildIdentifiers { get; set; }

        public VehicleChildUpdate()
        {

        }

        public VehicleChildUpdate(string vehicleGuid,List<InteractiveChildObjectIdentifier> interactiveChildIdentifiers)
        {
            VehicleGuid = vehicleGuid;
            InteractiveChildIdentifiers = interactiveChildIdentifiers;
        }
    }
}
