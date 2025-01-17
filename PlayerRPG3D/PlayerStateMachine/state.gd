extends Node
class_name State


signal transition(state, new_state, character) #used to transition to another state / called by State Machine Manager

# CUSTOM FUNCTIONS THAT WILL BE USED BY IT'S CHILDREN
# EACH CHILD WILL OVERRIDE THESE AND THEY WILL BE A UNIQUE STATE: WALK, JUMP, ETC. 

#Add code you want when entering state (Similar to Enter)
func enter():

	pass

#Add code you want when exiting state  
func exit():
	pass

#Add code you want Updating the state // This is= the inBuilt _process method (linked via the State Machine Manager)
func process_update(_delta):
	pass

#Add code you to run every physics frame // This is = the inBuilt _physics_process method (linked via the State Machine Manager)
func physics_update(_delta):
	pass

