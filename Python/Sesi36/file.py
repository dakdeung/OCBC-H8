import os
import sys

##Open files
print("> Open files")
f = open(os.path.join(sys.path[0], "test.txt"), encoding = 'utf-8')
# perform file operations
f.close()

##Writing Files
with open(os.path.join(sys.path[0], "test.txt"), 'w', encoding = 'utf-8') as f: 
    f.write("my first file\n")
    f.write("This file\n")
    f.write("contains three lines")

##Reading Files
print("\n\n> read files")
f = open(os.path.join(sys.path[0], "test.txt"),'r',encoding = 'utf-8')
print(f.read(4)) # read the first 4 data
print(f.read(4)) # read the next 4 data
print(f.read()) # read in the rest till end of file
print(f.read()) # further reading returns empty sting

print("\n\n> get the current file position")
print(f.tell()) 

print("\n\n> bring file cursor to initial position")
print(f.seek(0)) 
print(f.read())

print("\n\n> bring file cursor to initial position")
f.seek(0) 
for line in f:
  print(line, end = '')

print("\n> alternative")
f.seek(0)
print(f.readline())

print("\n> Open And Read")
with open(os.path.join(sys.path[0], "test.txt"), 'r', encoding = 'utf-8') as reader:
     print(reader.read())