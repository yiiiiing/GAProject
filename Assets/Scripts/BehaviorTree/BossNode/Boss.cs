using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using myAI;
using UnityEngine.UI;

namespace BossAI
{
    //[RequireComponent(typeof(Animator))]
    public class Boss : MonoBehaviour
    {
        // topNode
        private Node topNode;

        // animations for boss
        private Animator animator;

        [SerializeField] private float totalHealth;

        // the threshold for decreasing HP
        [SerializeField] private float decreaseHPthreshold;

        // if the enemy can heal it self
        [SerializeField] private float healRate = 0;
       
        [SerializeField] private float basicAttackRange; 
        [SerializeField] private float tailAttackRange;

        // if out of basic Attack Range but within walk range, then walk to player
        // if outof walk range, then run to player
        // walk range should be a little close to basicAttackRange
        [SerializeField] private float walkRange;
        // if in the attack range but not in front and not at back, then turn around

        // walk speed, run speed and turn around speed
        [SerializeField] private float walkSpeed;
        [SerializeField] private float runSpeed;
        [SerializeField] private float turnSpeed;

        // front and back angle
        [SerializeField] private float frontAngle;
        [SerializeField] private float backAngle;


        // the player transform
        [SerializeField] private Transform player;

        // cut scene
        [SerializeField] private GameObject cutSceneObject;


        // get health bar
        //public GameObject healthBarUI;
        public Slider healthSlide;


        private float m_currentHealth;

        public float currentHealth
        {
            get { return m_currentHealth; }
            // currentHealth is between the range(0, totalHealth)
            set { m_currentHealth = Mathf.Clamp(value, 0, totalHealth); }
        }      

        private float m_healthDecreaseAmount;

        public float healthDecreaseAmount
        {
            get { return m_healthDecreaseAmount; }
        }

        public void CleanHealthDecreaseAmount()
        {
            m_healthDecreaseAmount = 0.0f;
        }

        public void ChangeHP(float changeValue)
        {
            m_currentHealth += changeValue;

            // if changeValue is nagative, then boss is under attack
            if (changeValue < 0)
            {
                m_healthDecreaseAmount += Mathf.Abs(changeValue);
            }
        }


        private void Start()
        {
            m_currentHealth = totalHealth;
            animator = GetComponent<Animator>();
            InitBehaviorTree();
        }


        private void Update()
        {
            // update slider value
            healthSlide.value = m_currentHealth / totalHealth;

            // execute behavior tree
            if (cutSceneObject.GetComponent<myGame.BossCutScene>().GetIfCutSceneFinish())
            {
                topNode.Evaluate();
            }


            if (topNode.nodeState == NodeState.FAIL)
            {
                // play idle
                animator.Play("Idle");
            }

            // assuming that enemy continue to heal itself
            // TODO: add enemy healNode, make enemy heal itself under some conditions 
            m_currentHealth += Time.deltaTime * healRate;

        }


        private void InitBehaviorTree()
        {
            // initialized Node
            AnimationNode basicAttackNode = new AnimationNode("BasicAttack", animator);
            AnimationNode tailAttackNode = new AnimationNode("TailAttack", animator);
            AnimationNode takeOffNode = new AnimationNode("TakeOff", animator);
            IsInFrontOfNode isInFrontOfNode = new IsInFrontOfNode(this.transform,player, frontAngle);
            IsAtBackNode isAtBackNode = new IsAtBackNode(this.transform, player, backAngle);
            IsUnderAttackNode isUnderAttackNode = new IsUnderAttackNode(this, decreaseHPthreshold);

            // run to player
            RunToTargetNode runToPlayer = new RunToTargetNode(this.transform, player, runSpeed, turnSpeed, "Run", animator);

            // walk to player or turn to player
            RunToTargetNode turnToPlayer = new RunToTargetNode(this.transform, player, 0, turnSpeed, "Walk", animator);

            // if in the basic attack and tail attack
            RangeNode isInBasicAttackRange = new RangeNode(basicAttackRange, player, this.transform);
            RangeNode isInTailAttackRange = new RangeNode(tailAttackRange, player, this.transform);

            // if in the walk range
            RangeNode isInWalkRange = new RangeNode(walkRange, player, this.transform);

            /*Selector and Sequence*/
            //Attack Selector: BasicAttackSequence and TailAttackSequence
            Sequence BasicAttackSequence = new Sequence(new List<Node> { isInFrontOfNode, isInBasicAttackRange, basicAttackNode});
            Sequence TailAttackSequence = new Sequence(new List<Node> { isAtBackNode, isInTailAttackRange, tailAttackNode});
            Selector AttackSelector = new Selector(new List<Node> { BasicAttackSequence, TailAttackSequence});

            //TakeOffSequence: in takeOffRange && being attack and then take off
            Sequence TakeOffSequence = new Sequence(new List<Node> { isInBasicAttackRange, isUnderAttackNode, takeOffNode});

            // GoToPlayerSelector: RunToPlayerSequence, WalkToPlayerSequence
            Sequence RunToPlayerSequence = new Sequence(new List<Node> {
                isInFrontOfNode, new Invertor(isInWalkRange), runToPlayer
            });

            Sequence TurnToPlayerSequence = new Sequence(new List<Node> {
                new Invertor(isInFrontOfNode), new Invertor(isInBasicAttackRange), isUnderAttackNode, turnToPlayer
            });

            Selector GoToPlayerSelector = new Selector(new List<Node> { RunToPlayerSequence, TurnToPlayerSequence });

            // last, topNode
            topNode = new Selector(new List<Node> { TakeOffSequence, AttackSelector, GoToPlayerSelector});
        }
    }

}


