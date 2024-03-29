/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */



namespace RosSharp.RosBridgeClient.MessageTypes.Franka
{
    public class Errors : Message
    {
        public const string RosMessageName = "franka_msgs/Errors";

        public bool joint_position_limits_violation { get; set; }
        public bool cartesian_position_limits_violation { get; set; }
        public bool self_collision_avoidance_violation { get; set; }
        public bool joint_velocity_violation { get; set; }
        public bool cartesian_velocity_violation { get; set; }
        public bool force_control_safety_violation { get; set; }
        public bool joint_reflex { get; set; }
        public bool cartesian_reflex { get; set; }
        public bool max_goal_pose_deviation_violation { get; set; }
        public bool max_path_pose_deviation_violation { get; set; }
        public bool cartesian_velocity_profile_safety_violation { get; set; }
        public bool joint_position_motion_generator_start_pose_invalid { get; set; }
        public bool joint_motion_generator_position_limits_violation { get; set; }
        public bool joint_motion_generator_velocity_limits_violation { get; set; }
        public bool joint_motion_generator_velocity_discontinuity { get; set; }
        public bool joint_motion_generator_acceleration_discontinuity { get; set; }
        public bool cartesian_position_motion_generator_start_pose_invalid { get; set; }
        public bool cartesian_motion_generator_elbow_limit_violation { get; set; }
        public bool cartesian_motion_generator_velocity_limits_violation { get; set; }
        public bool cartesian_motion_generator_velocity_discontinuity { get; set; }
        public bool cartesian_motion_generator_acceleration_discontinuity { get; set; }
        public bool cartesian_motion_generator_elbow_sign_inconsistent { get; set; }
        public bool cartesian_motion_generator_start_elbow_invalid { get; set; }
        public bool cartesian_motion_generator_joint_position_limits_violation { get; set; }
        public bool cartesian_motion_generator_joint_velocity_limits_violation { get; set; }
        public bool cartesian_motion_generator_joint_velocity_discontinuity { get; set; }
        public bool cartesian_motion_generator_joint_acceleration_discontinuity { get; set; }
        public bool cartesian_position_motion_generator_invalid_frame { get; set; }
        public bool force_controller_desired_force_tolerance_violation { get; set; }
        public bool controller_torque_discontinuity { get; set; }
        public bool start_elbow_sign_inconsistent { get; set; }
        public bool communication_constraints_violation { get; set; }
        public bool power_limit_violation { get; set; }
        public bool joint_p2p_insufficient_torque_for_planning { get; set; }
        public bool tau_j_range_violation { get; set; }
        public bool instability_detected { get; set; }

        public Errors()
        {
            this.joint_position_limits_violation = false;
            this.cartesian_position_limits_violation = false;
            this.self_collision_avoidance_violation = false;
            this.joint_velocity_violation = false;
            this.cartesian_velocity_violation = false;
            this.force_control_safety_violation = false;
            this.joint_reflex = false;
            this.cartesian_reflex = false;
            this.max_goal_pose_deviation_violation = false;
            this.max_path_pose_deviation_violation = false;
            this.cartesian_velocity_profile_safety_violation = false;
            this.joint_position_motion_generator_start_pose_invalid = false;
            this.joint_motion_generator_position_limits_violation = false;
            this.joint_motion_generator_velocity_limits_violation = false;
            this.joint_motion_generator_velocity_discontinuity = false;
            this.joint_motion_generator_acceleration_discontinuity = false;
            this.cartesian_position_motion_generator_start_pose_invalid = false;
            this.cartesian_motion_generator_elbow_limit_violation = false;
            this.cartesian_motion_generator_velocity_limits_violation = false;
            this.cartesian_motion_generator_velocity_discontinuity = false;
            this.cartesian_motion_generator_acceleration_discontinuity = false;
            this.cartesian_motion_generator_elbow_sign_inconsistent = false;
            this.cartesian_motion_generator_start_elbow_invalid = false;
            this.cartesian_motion_generator_joint_position_limits_violation = false;
            this.cartesian_motion_generator_joint_velocity_limits_violation = false;
            this.cartesian_motion_generator_joint_velocity_discontinuity = false;
            this.cartesian_motion_generator_joint_acceleration_discontinuity = false;
            this.cartesian_position_motion_generator_invalid_frame = false;
            this.force_controller_desired_force_tolerance_violation = false;
            this.controller_torque_discontinuity = false;
            this.start_elbow_sign_inconsistent = false;
            this.communication_constraints_violation = false;
            this.power_limit_violation = false;
            this.joint_p2p_insufficient_torque_for_planning = false;
            this.tau_j_range_violation = false;
            this.instability_detected = false;
        }

        public Errors(bool joint_position_limits_violation, bool cartesian_position_limits_violation, bool self_collision_avoidance_violation, bool joint_velocity_violation, bool cartesian_velocity_violation, bool force_control_safety_violation, bool joint_reflex, bool cartesian_reflex, bool max_goal_pose_deviation_violation, bool max_path_pose_deviation_violation, bool cartesian_velocity_profile_safety_violation, bool joint_position_motion_generator_start_pose_invalid, bool joint_motion_generator_position_limits_violation, bool joint_motion_generator_velocity_limits_violation, bool joint_motion_generator_velocity_discontinuity, bool joint_motion_generator_acceleration_discontinuity, bool cartesian_position_motion_generator_start_pose_invalid, bool cartesian_motion_generator_elbow_limit_violation, bool cartesian_motion_generator_velocity_limits_violation, bool cartesian_motion_generator_velocity_discontinuity, bool cartesian_motion_generator_acceleration_discontinuity, bool cartesian_motion_generator_elbow_sign_inconsistent, bool cartesian_motion_generator_start_elbow_invalid, bool cartesian_motion_generator_joint_position_limits_violation, bool cartesian_motion_generator_joint_velocity_limits_violation, bool cartesian_motion_generator_joint_velocity_discontinuity, bool cartesian_motion_generator_joint_acceleration_discontinuity, bool cartesian_position_motion_generator_invalid_frame, bool force_controller_desired_force_tolerance_violation, bool controller_torque_discontinuity, bool start_elbow_sign_inconsistent, bool communication_constraints_violation, bool power_limit_violation, bool joint_p2p_insufficient_torque_for_planning, bool tau_j_range_violation, bool instability_detected)
        {
            this.joint_position_limits_violation = joint_position_limits_violation;
            this.cartesian_position_limits_violation = cartesian_position_limits_violation;
            this.self_collision_avoidance_violation = self_collision_avoidance_violation;
            this.joint_velocity_violation = joint_velocity_violation;
            this.cartesian_velocity_violation = cartesian_velocity_violation;
            this.force_control_safety_violation = force_control_safety_violation;
            this.joint_reflex = joint_reflex;
            this.cartesian_reflex = cartesian_reflex;
            this.max_goal_pose_deviation_violation = max_goal_pose_deviation_violation;
            this.max_path_pose_deviation_violation = max_path_pose_deviation_violation;
            this.cartesian_velocity_profile_safety_violation = cartesian_velocity_profile_safety_violation;
            this.joint_position_motion_generator_start_pose_invalid = joint_position_motion_generator_start_pose_invalid;
            this.joint_motion_generator_position_limits_violation = joint_motion_generator_position_limits_violation;
            this.joint_motion_generator_velocity_limits_violation = joint_motion_generator_velocity_limits_violation;
            this.joint_motion_generator_velocity_discontinuity = joint_motion_generator_velocity_discontinuity;
            this.joint_motion_generator_acceleration_discontinuity = joint_motion_generator_acceleration_discontinuity;
            this.cartesian_position_motion_generator_start_pose_invalid = cartesian_position_motion_generator_start_pose_invalid;
            this.cartesian_motion_generator_elbow_limit_violation = cartesian_motion_generator_elbow_limit_violation;
            this.cartesian_motion_generator_velocity_limits_violation = cartesian_motion_generator_velocity_limits_violation;
            this.cartesian_motion_generator_velocity_discontinuity = cartesian_motion_generator_velocity_discontinuity;
            this.cartesian_motion_generator_acceleration_discontinuity = cartesian_motion_generator_acceleration_discontinuity;
            this.cartesian_motion_generator_elbow_sign_inconsistent = cartesian_motion_generator_elbow_sign_inconsistent;
            this.cartesian_motion_generator_start_elbow_invalid = cartesian_motion_generator_start_elbow_invalid;
            this.cartesian_motion_generator_joint_position_limits_violation = cartesian_motion_generator_joint_position_limits_violation;
            this.cartesian_motion_generator_joint_velocity_limits_violation = cartesian_motion_generator_joint_velocity_limits_violation;
            this.cartesian_motion_generator_joint_velocity_discontinuity = cartesian_motion_generator_joint_velocity_discontinuity;
            this.cartesian_motion_generator_joint_acceleration_discontinuity = cartesian_motion_generator_joint_acceleration_discontinuity;
            this.cartesian_position_motion_generator_invalid_frame = cartesian_position_motion_generator_invalid_frame;
            this.force_controller_desired_force_tolerance_violation = force_controller_desired_force_tolerance_violation;
            this.controller_torque_discontinuity = controller_torque_discontinuity;
            this.start_elbow_sign_inconsistent = start_elbow_sign_inconsistent;
            this.communication_constraints_violation = communication_constraints_violation;
            this.power_limit_violation = power_limit_violation;
            this.joint_p2p_insufficient_torque_for_planning = joint_p2p_insufficient_torque_for_planning;
            this.tau_j_range_violation = tau_j_range_violation;
            this.instability_detected = instability_detected;
        }
    }
}
