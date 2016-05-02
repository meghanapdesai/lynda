class Dog:

	"""A simple dog class"""

	def __init__(self, name):
		self._name = name

	def speak(self):
		return "Woof!"
	
	def get_pet(self,pet="dog"):
		""" This factory method """
		pets = dict(dog=Dog("Hope"))
		return pets[pet]

class Cat:

	"""A simple cat class"""

	def __init__(self, name):
		self._name = name

	def speak(self):
		return "Meow!"
	
	def get_pet(self,pet="dog"):
		""" This factory method """
		pets = dict(dog=Dog("Hope"))
		return pets[pet]	 	