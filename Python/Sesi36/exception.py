import sys

print("\n\n> The AssertionError Exception: Handling Exception")
def os_interaction():
    assert ('linux' in sys.platform), "Function can only run on Linux systems."
    assert ('windows' in sys.platform), "This code runs on Windows only."
    print('Doing something.')

try:
    os_interaction()
except AssertionError as error:
    print(error)
    print('The os_interaction() function was not executed')

print("\n\n> With Else Clause")
try:
    with open('test.txt') as file:
        read_data = file.read()
    with open('file.log') as file:
        read_data = file.read()
    print('semua read berhasil')
except FileNotFoundError as error:    
    print(error)
else:    
    print('Executing the else clause.')


print("\n\n> Cleaning Up After Using finally")
try:
    os_interaction()
except AssertionError as error:
    print(error)
else:
    try:
        with open('file.log') as file:
            read_data = file.read()
    except FileNotFoundError as fnf_error:
        print(fnf_error)
finally:
    print('Cleaning up, irrespective of any exceptions.')