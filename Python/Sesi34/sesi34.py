print("\nIf statement")
x = 0
y = 5
if x < y:                            
    print('yes')
if y < x:                            
    print('yes')
if x:                                
    print('yes')
if y:                                
    print('yes')
if 'aul' in 'grault':                
    print('yes')
if 'quux' in ['foo', 'bar', 'baz']:  
    print('yes')

print("\nGoruping Statement")
weather = 'cloudy'
if weather == 'nice':
    print('Mow the lawn')
    print('Weed the garden')
    print('Take the dog for a walk')

if 'foo' in ['bar', 'baz', 'qux']:
    print('Expression was true')
    print('Executing statement in suite')
    print('...')
    print('Done.')
print('After conditional')

print("\nGoruping Statement")
weather = 'cloudy'
if weather == 'nice':
    print('Mow the lawn')
    print('Weed the garden')
    print('Take the dog for a walk')
else:
    print('Read a book')
    print('Watch movies')

x = 20
if x < 50:
    print('(first suite)')
    print('x is small')
else:
    print('(second suite)')
    print('x is large')

hargaBuku = 20000
hargaMajalah = 5000
uang = 7000
if uang > hargaBuku:
    print('Beli buku')
elif uang > hargaMajalah:
    print('Beli majalah')
else:
    print('Tidak beli buku')

print("\nOne line if")
x = 3
if x == 1: print('foo'); print('bar'); print('baz')
elif x == 2: print('qux'); print('quux')
else: print('corge'); print('grault')

nomor_undian = 80
if nomor_undian < 100:
    prize = 'box1'
else:
    prize = 'box2'
prize = 'box1' if nomor_undian < 100 else 'box2'
print(prize)

print("\nLooping")
n = 5

print("While Loop")
while n > 0:
    n -= 1
    print(n)

print("Python break and continue Statements")

while n > 0:
    n -= 1
    if n == 2:
        break 
    print(n)
print('Loop ended.')

while n > 0:    
    n -= 1    
    if n == 2:       
         continue    
    print(n)
print('Loop ended.')

print("\nThe else Clause in loop")
while n > 0:
    n -= 1
    print(n)
else:
    print('Loop done.')

print("\nNested loop break")
i = 0
while i <= 10:
    if i == 3: break
    j = 0
    while j <= 5:
        print(i, j)
        j += 1
        if(j == 3): continue
        print('---')
    i += 1

a = ['foo', 'bar']

while len(a):
    print(a.pop(0))
    
    b = ['baz', 'qux']
    
    while len(b):
        print('>', b.pop(0))

print("\nOne line while loop")
n = 5
while n > 0: n -= 1; print(n)

print("\nFor loop")
a = ['foo', 'bar', 'baz']
for i in a:
    print(i)
    
print("\nRange")
x = range(0, 100, 20)
for n in x:
    print(n)

print("\nUsing dictionary and build in function items() and values() for dictionary")
d = {'foo': 1, 'bar': 2, 'baz': 3}
for k in d.values():
    print(k)
for k, v in d.items():
    print(k, ':', v)