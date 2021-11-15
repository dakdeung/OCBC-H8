print("\nDefining and Accessing Dictionary")
MLB_team = { 
    'Colorado': 'Rockies', 
    'Boston': ['Red Sox', 'White Fox'], 
    'Minnesota': 'Twins', 
    'Seattle': 'Mariners', 
    'Kansas City': 'Royals'
}

print(MLB_team['Seattle'])

MLB_team['Boston'][0] = 'Red Fox'
print(MLB_team['Boston'])

print("\nBuilding a dictionary incrementally")
person = {}
person['fname'] = 'Hack'
person['lname'] = '8'
person['age'] = 51
person['spouse'] = 'Edna'
person['children'] = ['Ralph', 'Betty', 'Joey']
person['pets'] = {'dog': 'Fido', 'cat': 'Sox'}
print(person)
print(person['children'][1])
print(person['pets']['dog'])
person['pets']['cat'] = 'Renamed Sox'
print(person['pets']['cat'])

print("\nPython Lists")
primary_colors = ['Red', 'Green', 'Blue']
even_numbers_berofre_ten = [2, 4, 6, 8]
event_a = ['Surabaya', 1300]
print(str(type(even_numbers_berofre_ten)) +' '+ str(type(event_a)))
event_b = ['Manado', 1450]
events = [event_a, event_b]
print(events)

print("\nModifying & Access List Value")
events = [
    primary_colors,
    even_numbers_berofre_ten
]
print(events[0][1]) 
print(event_a[-1]) 
print(len(event_a))
print("A single value in a list can be replaced by indexing and simple assignment:")
a = ['foo', 'bar', 'baz', 'qux', 'quux', 'corge']
a[2] = 10
a[-1] = 20
print(a)

print("What if you want to change several contiguous elements in a list at one time? Python allows this with sliceassignment, which has the following syntax:")
print(a[1:4])

a[1:4] = [1.1, 2.2, 3.3, 4.4, 5.5]
print(a)

fruits = ['orange', 'apple', 'pear', 'banana', 'kiwi', 'apple', 'banana']
fruits.count('apple')
fruits.count('tangerine')
fruits.index('banana')
fruits.index('banana', 4)
fruits.reverse() 
fruits.append('grape') 
fruits.sort()
fruits.pop() 
fruits.clear()

print("\nFloat")
print(4.2)
print(type(4.2))
print(4.)
print(.2)
print(.4e7)
print(4.2e-4)

print("\nStrings")
print("Hacktiv8")
print(type("Hacktiv8"))
print("This string contains a single quote (') character.")
print('This string contains a double quote (") character.')

print("\nPython 3 provides a Boolean data type. Objects of Boolean type may have one of two values, True or False:")
print(type(True))
print(type(False))

print("\nWhen you compare two values, the expression is evaluated and Python returns the Boolean answer:")
print(100 > 200)
print(100 == 200)
print(100 < 200)

print("\nVariable Assignment")
n = 300
print(n)
print("Chained Type assignment")
a = b = c = 300
print(a, b, c)

print("\nVariable Names")
name = "Hacktiv8"
Age = 54
has_laptops = True
print(name, Age, has_laptops)

print("\nOperators and Expressions")
a = 10
b = 20
print(a + b)
print(a + b - 5)

print("\nArithmetic Operators")
a = 4
b = 3
print(a + b)
print(a - b)
print(a * b)
print(a / b)
print(a % b)
print(a ** b)

print("\nComparison Operators")
a = 10
b = 20
print(a == b)
print(a != b)
print(a <= b)
print(a >= b)

print("\nString Manipulation")
s = 'foo'
t = 'bar'
print(s + t)
print(s * 4)
print(s.capitalize())
print(s.lower())
print(s.swapcase())

print("\nPython Tuple")
t = ('foo', 'bar', 'baz', 'qux', 'quux', 'corge')
print(t)
print(t[0])
print(t[-1])

(s1, s2, s3, s4) = ('foo', 'bar', 'baz', 'qux')
print(s1)

tuple_with_only_one_element = ('like',) 