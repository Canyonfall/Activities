# in-class-activities
## Devlogs
### W1
itch link: https://canyonfall.itch.io/mon-sep-28

Answer: The camera(pov) will not move, but the cat will move around when player press wasd. 


### W2
1. The r, g, and b variables are floats because RGB color values in Unity can have decimal values between 0.0 and 1.0.

2. The _bounces variable is an int because it keeps track of how many times the ball has bounced. A bounce count is a whole number.

3. The error showed that the line was missing a semicolon at the end. 


### W3
#### Activity 1: Table Number 9
1. public string GetResponse(int friendshipLevel, bool knowsSecret)
2. public void SetLightDimness(float currentSanityLevel)
3. public bool DidPlayerHitBeat(float timeHit)

#### Activity 2
Metaphor: Classes like cookie cutters and Components like the actual cookies made from those cutters.

A class is the cookie cutter, a template that determines what kind of cookie you can make, and components are the actual cookies made using the cutter. You can create multiple components from the same class, like you can make multiple cookies with one cutter. Member variables are the traits of each cookie, such as flavor, color, or size. Each cookie can have different traits. Then, methods are the actions the cookie can perform, like being able to crumble or change color.

#### Activity 3
Because the speed multiplier is greater than 1, so the speed of the ball is increasing, and the ball color will multiply color multiplier if the speed is greater than _speedThreshold. In this way the color of ball will get extremely bright till totally white. 


### W4
Table #7

1. I add Rigidbody component to the cat and the ball, in this way the cat can kick the ball, and the cat and ball can bounce off the wall. I add Is Trigger component to the goal. Because in this way the ball will detect when it is in the goal area, and still pass through the goal.

2. At the beginning of testing, when my cat touched the edge of the platform, it suddenly became rotating very very fast, tilting... Then I found that I did not check the Freeze Rotation X & Z for the kitty. During the coding process, I had some console error, but most of them are grammar error, like forgetting "f" after a float, missing bracket in a method... I fixed them all and finally worked ^_^


### W6
The DeerW5 class needs a private Transform variable to store target GameObject the deer walk towards, and it should be add  [SerializeField] so I can modify the target in the Inspector. Then this class needs a Start() method to initialize and GetComponent<NavMeshAgent>() to get the NavMeshAgent Component attached to the deer. The Start() method should get the NavMeshAgent Component from the deer GameObject and use it to set the destination to the target transform's position, and this should tell the deer where to go at the beginning of the game. 


### W7
#### Activity 1
Assigned class-resource topic: III. General C# coding
Shared Google Doc: https://docs.google.com/document/d/179zDHWaZxqnBjZy0PR_jNnTRrSRR3sZZ_zDTDfMMah8/edit?usp=sharing

#### Activity 2
Variables in BatW6: _speed, _target, _isChasing. Methods: Update(), StartChasing, StopChasing(). 
StartChasing stores the target and enables chasing. StopChasing disables chasing. Update uses Vector3.MoveTowards and Time.deltaTime to move toward the target only while chasing is enabled. The manager checks each bat in an array with a for loop, starts/stops its chase, and handles message cooldowns with a matching float array.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
