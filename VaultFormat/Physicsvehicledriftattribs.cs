using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BundleUtilities;

namespace VaultFormat
{
    public class Physicsvehicledriftattribs : IAttribute
    {
        public AttributeHeader header { get; set; }
        public SizeAndPositionInformation info { get; set; }

        public Vector3I DriftScaleToYawTorque { get; set; }
        public float WheelSlip { get; set; }
        public float TimeToCapScale { get; set; }
        public float TimeForNaturalDrift { get; set; }
        public float SteeringDriftScaleFactor { get; set; }
        public float SideForcePeakDriftAngle { get; set; }
        public float SideForceMagnitude { get; set; }
        public float SideForceDriftSpeedCutOff { get; set; }
        public float SideForceDriftAngleCutOff { get; set; }
        public float SideForceDirftScaleCutOff { get; set; }
        public float NeutralTimeToReduceDrift { get; set; }
        public float NaturalYawTorqueCutOffAngle { get; set; }
        public float NaturalYawTorque { get; set; }
        public float NaturalDriftTimeToReachBaseSlip { get; set; }
        public float NaturalDriftStartSlip { get; set; }
        public float NaturalDriftScaleDecay { get; set; }
        public float MinSpeedForDrift { get; set; }
        public float InitialDriftPushTime { get; set; }
        public float InitialDriftPushScaleLimit { get; set; }
        public float InitialDriftPushDynamicInc { get; set; }
        public float InitialDriftPushBaseInc { get; set; }
        public float GripFromSteering { get; set; }
        public float GripFromGasLetOff { get; set; }
        public float GripFromBrake { get; set; }
        public float GasDriftScaleFactor { get; set; }
        public float ForcedDriftTimeToReachBaseSlip { get; set; }
        public float ForcedDriftStartSlip { get; set; }
        public float DriftTorqueFallOff { get; set; }
        public float DriftSidewaysDamping { get; set; }
        public float DriftMaxAngle { get; set; }
        public float DriftAngularDamping { get; set; }
        public float CounterSteeringDriftScaleFactor { get; set; }
        public float CappedScale { get; set; }
        public float BrakingDriftScaleFactor { get; set; }
        public float BaseCounterSteeringDriftScaleFactor { get; set; }

        public Physicsvehicledriftattribs(SizeAndPositionInformation chunk, AttributeHeader dataChunk)
        {
            header = dataChunk;
            info = chunk;
        }

        public int getDataSize()
        {
            List<byte[]> bytes = new List<byte[]>();
            bytes.Add(DriftScaleToYawTorque.toBytes());
            bytes.Add(BitConverter.GetBytes(WheelSlip));
            bytes.Add(BitConverter.GetBytes(TimeToCapScale));
            bytes.Add(BitConverter.GetBytes(TimeForNaturalDrift));
            bytes.Add(BitConverter.GetBytes(SteeringDriftScaleFactor));
            bytes.Add(BitConverter.GetBytes(SideForcePeakDriftAngle));
            bytes.Add(BitConverter.GetBytes(SideForceMagnitude));
            bytes.Add(BitConverter.GetBytes(SideForceDriftSpeedCutOff));
            bytes.Add(BitConverter.GetBytes(SideForceDriftAngleCutOff));
            bytes.Add(BitConverter.GetBytes(SideForceDirftScaleCutOff));
            bytes.Add(BitConverter.GetBytes(NeutralTimeToReduceDrift));
            bytes.Add(BitConverter.GetBytes(NaturalYawTorqueCutOffAngle));
            bytes.Add(BitConverter.GetBytes(NaturalYawTorque));
            bytes.Add(BitConverter.GetBytes(NaturalDriftTimeToReachBaseSlip));
            bytes.Add(BitConverter.GetBytes(NaturalDriftStartSlip));
            bytes.Add(BitConverter.GetBytes(NaturalDriftScaleDecay));
            bytes.Add(BitConverter.GetBytes(MinSpeedForDrift));
            bytes.Add(BitConverter.GetBytes(InitialDriftPushTime));
            bytes.Add(BitConverter.GetBytes(InitialDriftPushScaleLimit));
            bytes.Add(BitConverter.GetBytes(InitialDriftPushDynamicInc));
            bytes.Add(BitConverter.GetBytes(InitialDriftPushBaseInc));
            bytes.Add(BitConverter.GetBytes(GripFromSteering));
            bytes.Add(BitConverter.GetBytes(GripFromGasLetOff));
            bytes.Add(BitConverter.GetBytes(GripFromBrake));
            bytes.Add(BitConverter.GetBytes(GasDriftScaleFactor));
            bytes.Add(BitConverter.GetBytes(ForcedDriftTimeToReachBaseSlip));
            bytes.Add(BitConverter.GetBytes(ForcedDriftStartSlip));
            bytes.Add(BitConverter.GetBytes(DriftTorqueFallOff));
            bytes.Add(BitConverter.GetBytes(DriftSidewaysDamping));
            bytes.Add(BitConverter.GetBytes(DriftMaxAngle));
            bytes.Add(BitConverter.GetBytes(DriftAngularDamping));
            bytes.Add(BitConverter.GetBytes(CounterSteeringDriftScaleFactor));
            bytes.Add(BitConverter.GetBytes(CappedScale));
            bytes.Add(BitConverter.GetBytes(BrakingDriftScaleFactor));
            bytes.Add(BitConverter.GetBytes(BaseCounterSteeringDriftScaleFactor));
            Console.WriteLine(bytes.SelectMany(i => i).Count());
            return CountingUtilities.AddPadding(bytes);
        }

        public AttributeHeader getHeader()
        {
            return header;
        }

        public SizeAndPositionInformation getInfo()
        {
            return info;
        }

        public void Read(ILoader loader, BinaryReader2 br)
        {
            DriftScaleToYawTorque = br.ReadVector3I();
            WheelSlip = br.ReadSingle();
            TimeToCapScale = br.ReadSingle();
            TimeForNaturalDrift = br.ReadSingle();
            SteeringDriftScaleFactor = br.ReadSingle();
            SideForcePeakDriftAngle = br.ReadSingle();
            SideForceMagnitude = br.ReadSingle();
            SideForceDriftSpeedCutOff = br.ReadSingle();
            SideForceDriftAngleCutOff = br.ReadSingle();
            SideForceDirftScaleCutOff = br.ReadSingle();
            NeutralTimeToReduceDrift = br.ReadSingle();
            NaturalYawTorqueCutOffAngle = br.ReadSingle();
            NaturalYawTorque = br.ReadSingle();
            NaturalDriftTimeToReachBaseSlip = br.ReadSingle();
            NaturalDriftStartSlip = br.ReadSingle();
            NaturalDriftScaleDecay = br.ReadSingle();
            MinSpeedForDrift = br.ReadSingle();
            InitialDriftPushTime = br.ReadSingle();
            InitialDriftPushScaleLimit = br.ReadSingle();
            InitialDriftPushDynamicInc = br.ReadSingle();
            InitialDriftPushBaseInc = br.ReadSingle();
            GripFromSteering = br.ReadSingle();
            GripFromGasLetOff = br.ReadSingle();
            GripFromBrake = br.ReadSingle();
            GasDriftScaleFactor = br.ReadSingle();
            ForcedDriftTimeToReachBaseSlip = br.ReadSingle();
            ForcedDriftStartSlip = br.ReadSingle();
            DriftTorqueFallOff = br.ReadSingle();
            DriftSidewaysDamping = br.ReadSingle();
            DriftMaxAngle = br.ReadSingle();
            DriftAngularDamping = br.ReadSingle();
            CounterSteeringDriftScaleFactor = br.ReadSingle();
            CappedScale = br.ReadSingle();
            BrakingDriftScaleFactor = br.ReadSingle();
            BaseCounterSteeringDriftScaleFactor = br.ReadSingle();
            br.SkipPadding();
        }

        public void Write(BinaryWriter wr)
        {
            wr.Write(DriftScaleToYawTorque.toBytes());
            wr.Write(WheelSlip);
            wr.Write(TimeToCapScale);
            wr.Write(TimeForNaturalDrift);
            wr.Write(SteeringDriftScaleFactor);
            wr.Write(SideForcePeakDriftAngle);
            wr.Write(SideForceMagnitude);
            wr.Write(SideForceDriftSpeedCutOff);
            wr.Write(SideForceDriftAngleCutOff);
            wr.Write(SideForceDirftScaleCutOff);
            wr.Write(NeutralTimeToReduceDrift);
            wr.Write(NaturalYawTorqueCutOffAngle);
            wr.Write(NaturalYawTorque);
            wr.Write(NaturalDriftTimeToReachBaseSlip);
            wr.Write(NaturalDriftStartSlip);
            wr.Write(NaturalDriftScaleDecay);
            wr.Write(MinSpeedForDrift);
            wr.Write(InitialDriftPushTime);
            wr.Write(InitialDriftPushScaleLimit);
            wr.Write(InitialDriftPushDynamicInc);
            wr.Write(InitialDriftPushBaseInc);
            wr.Write(GripFromSteering);
            wr.Write(GripFromGasLetOff);
            wr.Write(GripFromBrake);
            wr.Write(GasDriftScaleFactor);
            wr.Write(ForcedDriftTimeToReachBaseSlip);
            wr.Write(ForcedDriftStartSlip);
            wr.Write(DriftTorqueFallOff);
            wr.Write(DriftSidewaysDamping);
            wr.Write(DriftMaxAngle);
            wr.Write(DriftAngularDamping);
            wr.Write(CounterSteeringDriftScaleFactor);
            wr.Write(CappedScale);
            wr.Write(BrakingDriftScaleFactor);
            wr.Write(BaseCounterSteeringDriftScaleFactor);
            wr.WritePadding();
        }

    }
}