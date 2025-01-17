extends State
class_name run
@export var character: CharacterBody2D
@export var speed:float = 100.0
@onready var animation_player = $AnimationPlayer
var direction:Vector2 = Vector2.ZERO
var direction_angle:float = 0
var direction_text:String = ""
var current_velocity
var is_moving:bool = false

# Called when the node enters the scene tree for the first time.
func _ready() -> void:
	pass # Replace with function body.

#Add code you want when entering state
func enter():
	pass

#Add code you want when entering state
func exit():
	pass

#Add code you want Updating the state // This is= the inBuilt _process method (linked via the State Machine Manager)
func process_update(_delta):
	current_velocity = character.velocity

#Add code you to run every physics frame // This is = the inBuilt _physics_process method (linked via the State Machine Manager)
func physics_update(delta):
	manage_run(delta)

func manage_run(delta) -> void:
	current_velocity = character.velocity

	if character and Input.is_anything_pressed():	
		direction.x = Input.get_action_strength("right") - Input.get_action_strength("left")
		direction.y = Input.get_action_strength("down") - Input.get_action_strength("up")
		direction = direction.normalized()

		if direction:
			character.velocity = direction * speed
			#character.move_and_slide()
			character.move_and_collide(character.velocity * delta)
			#for top_down we can use move_And_collide: move_and_slide is designed for a platformer things like for example where you fall onto a floor (rigid body) and run (slide) across it	
			is_moving = true
			
	else: #If velocity = Vector.ZERO (not moving) - Alternative code
		is_moving = false
		transition_to_idle()

func transition_to_idle() -> void:
	if character and !is_moving: #Transition to Idle if not moving
		transition.emit(self,"idle", character)
		direction = Vector2.ZERO


func transition_to_run() -> void:
	#if velocity is less than a certain valye go back to walk
	pass
