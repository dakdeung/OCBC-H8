class Dog():
    def __init__(self,name,age):
        self.name = name
        self.age = age

    # Instance method
    def description(self):
        return f"{self.name} is {self.age} years old"

    # Another instance method
    def speak(self, sound):
        return f"{self.name} says {sound}"

miles = Dog('Miles', 4)
budy = Dog('Budy',21)

print(miles.name)
print(miles.description())
print(miles.speak("Goog"))

class Mom():
    def __init__(self,name,hair_color):
        self.name = name
        self.hair_color = hair_color

class Children(Mom):
    def __init__(self, name, new_hair_color):
        super().__init__(name, new_hair_color)
        self.name = name
        self.new_hair_color = new_hair_color

mom = Mom('ani', 'hitam')
print(mom.hair_color)
