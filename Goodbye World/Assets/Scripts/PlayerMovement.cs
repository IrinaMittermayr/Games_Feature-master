using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {

        //Constants
        public float m_gravity;
        public float m_jumpVelocity;
        public float m_jumpVelocityShroom;
        public float m_climbingVelocity;
        public float m_movementSpeedGround;

        public float m_slopeLimit;
        public float m_slideSpeed;

        public bool m_isFallEnabled;

        





        //private fields
        private float _currentVerticalVelocity;
        private float _currentGravity;
        private float _currentMovementSpeed;
        private float _speed;
        private Vector3 mLastPosition;
        private Quaternion _lookDirection;
        private Vector3 hitNormal;
        private bool isGrounded;



        private bool _isSprintingPossible;


        private Collider _collider;
        private Vector3 _movement;
        private CharacterController _characterController;

        //properties

        public float CurrentMovementSpeed
        {
            get { return _currentMovementSpeed; }
            set { _currentMovementSpeed = value; }
        }








        //Initialize some values
        void Start()
        {
            _characterController = GetComponent<CharacterController>();

            _currentMovementSpeed = m_movementSpeedGround;
            mLastPosition = transform.position;
            Cursor.lockState = CursorLockMode.Locked;
        }


        // Like Start() but gets called regardless of
        // wheter the script is enabled or not.
        void Awake()
        {

        }

        // Everything with physics
        void FixedUpdate()
        {
            _currentGravity = m_gravity;

            _speed = (transform.position - this.mLastPosition).magnitude / Time.deltaTime;
            this.mLastPosition = transform.position;


            if (_characterController.isGrounded)
                _currentMovementSpeed = m_movementSpeedGround;

            

            _movement = Vector3.zero;
            if (_characterController.isGrounded)
            {
                _currentVerticalVelocity = -_currentGravity * Time.deltaTime;
                if (Input.GetAxis("Jump") > 0 && GetComponent<SpaceBarAction>().isJumpEnabled)
                {
                    _currentVerticalVelocity = m_jumpVelocity;
                    _currentMovementSpeed = (_speed > 0) ? _speed : 3;
                }
            }


            else
            {
                Debug.Log(_currentVerticalVelocity);
                if(m_isFallEnabled)
                {
                    _currentVerticalVelocity -= 10 * Time.deltaTime;
                }
                else
                {
                    _currentVerticalVelocity -= _currentGravity * Time.deltaTime;
                }
                
            }


            /*----------------------------------------------------*/


                Move();


            isGrounded = (Vector3.Angle(Vector3.down, hitNormal) >= m_slopeLimit);



        }



        void Move()
        {


            _movement.x = Input.GetAxis("Horizontal") * _currentMovementSpeed;
            _movement.y = _currentVerticalVelocity;
            _movement.z = Input.GetAxis("Vertical") * _currentMovementSpeed;



            _characterController.Move(transform.rotation * _movement * Time.deltaTime);

            if (!isGrounded && _currentGravity != 0)
            {
                _movement.x = ((1f - hitNormal.y) * hitNormal.x) * m_slideSpeed;
                _movement.z = ((1f - hitNormal.y) * hitNormal.z) * m_slideSpeed;
                _characterController.Move(_movement * Time.deltaTime);
            }



        }

        void OnControllerColliderHit(ControllerColliderHit hit)
        {
            hitNormal = hit.normal;
        }


    }

}
