//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Moveit
{
    [Serializable]
    public class ChangeDriftDimensionsRequest : Message
    {
        public const string k_RosMessageName = "moveit_msgs/ChangeDriftDimensions";
        public override string RosMessageName => k_RosMessageName;

        //  For use with moveit_jog_arm Cartesian planner
        // 
        //  Allow the robot to drift along these dimensions in a smooth but unregulated way.
        //  Give 'true' to enable drift in the direction, 'false' to disable.
        //  For example, may allow wrist rotation by drift_x_rotation == true.
        public bool drift_x_translation;
        public bool drift_y_translation;
        public bool drift_z_translation;
        public bool drift_x_rotation;
        public bool drift_y_rotation;
        public bool drift_z_rotation;
        //  Not implemented as of Jan 2020 (for now assumed to be the identity matrix). In the future it will allow us to transform
        //  from the jog control frame to a unique drift frame, so the robot can drift along off-principal axes
        public Geometry.TransformMsg transform_jog_frame_to_drift_frame;

        public ChangeDriftDimensionsRequest()
        {
            this.drift_x_translation = false;
            this.drift_y_translation = false;
            this.drift_z_translation = false;
            this.drift_x_rotation = false;
            this.drift_y_rotation = false;
            this.drift_z_rotation = false;
            this.transform_jog_frame_to_drift_frame = new Geometry.TransformMsg();
        }

        public ChangeDriftDimensionsRequest(bool drift_x_translation, bool drift_y_translation, bool drift_z_translation, bool drift_x_rotation, bool drift_y_rotation, bool drift_z_rotation, Geometry.TransformMsg transform_jog_frame_to_drift_frame)
        {
            this.drift_x_translation = drift_x_translation;
            this.drift_y_translation = drift_y_translation;
            this.drift_z_translation = drift_z_translation;
            this.drift_x_rotation = drift_x_rotation;
            this.drift_y_rotation = drift_y_rotation;
            this.drift_z_rotation = drift_z_rotation;
            this.transform_jog_frame_to_drift_frame = transform_jog_frame_to_drift_frame;
        }

        public static ChangeDriftDimensionsRequest Deserialize(MessageDeserializer deserializer) => new ChangeDriftDimensionsRequest(deserializer);

        private ChangeDriftDimensionsRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.drift_x_translation);
            deserializer.Read(out this.drift_y_translation);
            deserializer.Read(out this.drift_z_translation);
            deserializer.Read(out this.drift_x_rotation);
            deserializer.Read(out this.drift_y_rotation);
            deserializer.Read(out this.drift_z_rotation);
            this.transform_jog_frame_to_drift_frame = Geometry.TransformMsg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.drift_x_translation);
            serializer.Write(this.drift_y_translation);
            serializer.Write(this.drift_z_translation);
            serializer.Write(this.drift_x_rotation);
            serializer.Write(this.drift_y_rotation);
            serializer.Write(this.drift_z_rotation);
            serializer.Write(this.transform_jog_frame_to_drift_frame);
        }

        public override string ToString()
        {
            return "ChangeDriftDimensionsRequest: " +
            "\ndrift_x_translation: " + drift_x_translation.ToString() +
            "\ndrift_y_translation: " + drift_y_translation.ToString() +
            "\ndrift_z_translation: " + drift_z_translation.ToString() +
            "\ndrift_x_rotation: " + drift_x_rotation.ToString() +
            "\ndrift_y_rotation: " + drift_y_rotation.ToString() +
            "\ndrift_z_rotation: " + drift_z_rotation.ToString() +
            "\ntransform_jog_frame_to_drift_frame: " + transform_jog_frame_to_drift_frame.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}