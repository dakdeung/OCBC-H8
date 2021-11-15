# Function convert digunakan untuk menconvert suhu
# Funciton ini terdapat 3 parameter yaitu temperature, degree, options
#   Temperature adalah suhu yang berupa int
#   Degree adalah besaran suhu ex: C | Celcius, K | Kelvin, F | Fahrenheit
#   Options memiliki default value none, digunakan option untuk mendapatkan value untuk di olah
def converter(temperature, degree, options = None):
    # jika degree nya berupa C maka akan menjalankan conver Celcius
    # lower digunakan untuk membuat value menjadi lowcase
    if degree.lower() == 'c' or degree.lower() == 'celcius':  
        # variable convert digunakan untuk menampung hasil operasi aritmatika 
        convert = temperature + 273.15
        # variable fahrenheit digunakan untuk menampung hasil aritmatika untuk mendapatkan value fahrenheit
        fahrenheit = (temperature * 1.8) + 32
        # varibale message digunakan untuk menampung hasil yang akan kembalikan
        # round digunakan untuk membuat value hanya memiliki 2 decimal
        message = f'-----Convert Suhu °{degree.capitalize()}-----\nCelcius : {round(temperature, 2)}°C\nKelvin  : {round(convert, 2)}°K\nFahrenheit  : {round(fahrenheit, 2)}°F\n'
        # jika options tidak bernilai none, digunakan untuk mengembalikan nilai tanpa message
        if options is not None:     
            # mengembalikan nilai untuk di olah
            return fahrenheit
        # jika options bernilai none, digunakan untuk mengembalikan message       
        else:       
            # mengembalikan message untuk di tampilkan
            return message  
    #jika degree nya berupa K maka akan menjalankan conver Kelvin
    # lower digunakan untuk membuat value menjadi lowcase
    elif degree.lower() == 'k' or degree.lower() == 'kelvin':  
        # variable convert digunakan untuk menampung hasil operasi aritmatika    
        convert = temperature - 273.15
        # varibale message digunakan untuk menampung hasil yang akan kembalikan
        fahrenheit = (temperature * 1.8) - 459.67
        # variable fahrenheit digunakan untuk menampung hasil aritmatika untuk mendapatkan value fahrenheit
        # round digunakan untuk membuat value hanya memiliki 2 decimal
        message = f'-----Convert Suhu °{degree.capitalize()}-----\nCelcius : {round(convert, 2)}°C\nKelvin  : {round(temperature, 2)}°K\nFahrenheit  : {round(fahrenheit, 2)}°F\n'
        # jika options tidak bernilai none, digunakan untuk mengembalikan nilai tanpa message
        if options is not None:
            # mengembalikan nilai untuk di olah
            return fahrenheit
        # jika options bernilai none, digunakan untuk mengembalikan message       
        else:
            # mengembalikan message untuk di tampilkan
            return message
    # jika degree nya berupa F maka akan menjalankan conver Fahrenheit
    # lower digunakan untuk membuat value menjadi lowcase
    elif degree.lower() == 'f' or degree.lower() == 'fahrenheit':
        # variable fahrenheit digunakan untuk menampung hasil aritmatika untuk mendapatkan value celcius 
        celcius = (temperature - 32) / 1.8
        # variable fahrenheit digunakan untuk menampung hasil aritmatika untuk mendapatkan value kelvin
        kelvin = (temperature + 459.67) / 1.8
        # varibale message digunakan untuk menampung hasil yang akan kembalikan
        # round digunakan untuk membuat value hanya memiliki 2 decimal
        message = f'-----Convert Suhu °{degree.capitalize()}-----\nCelcius : {round(celcius, 2)}°C\nKelvin  : {round(kelvin, 2)}°K\nFahrenheit  : {round(temperature, 2)}°F\n'
        # jika options tidak bernilai none, digunakan untuk mengembalikan nilai tanpa message
        if options is not None:     
            # mengembalikan nilai untuk di olah
            return temperature
        # jika options bernilai none, digunakan untuk mengembalikan message       
        else:       
            # mengembalikan message untuk di tampilkan
            return message 
    #jika degree nya bernilai selain C ,K , F maka akan mengembalika message
    else: 
        # mengembalikan message untuk di tampilkan  
        return "Degree Symbol not recognise\n"


# Function convertFahrenheit digunakan untuk menconvert suhu kedalam fahrenheit
# Funciton ini terdapat 2 parameter yaitu temperature dan degree
#   Temperature adalah suhu yang berupa int
#   Degree adalah besaran suhu ex: C | Celcius, K | Kelvin, F | Fahrenheit
def convertFahrenheit(temperature, degree):
    # variable value digunakan untuk menampung hasil yang didapat dari function converter
    value = converter(temperature,degree,True)
    # varibale message digunakan untuk menampung hasil yang akan kembalikan
    # round digunakan untuk membuat value hanya memiliki 2 decimal
    message = f'-----Convert Suhu to Fahrenheit-----\nFahrenheit  : {round(value, 2)}°F\n'
    # mengembalikan message untuk di tampilkan
    return message


# Function convertFromFahrenheit digunakan untuk menconvert suhu dari fahrenheit ke celcius dan kelvin
# Funciton ini terdapat 1 parameter yaitu temperature
#   Temperature adalah suhu yang berupa int
def convertFromFahrenheit(temperature):
    # variable fahrenheit digunakan untuk menampung hasil aritmatika untuk mendapatkan value celcius 
    celcius = (temperature - 32) / 1.8
    # variable fahrenheit digunakan untuk menampung hasil aritmatika untuk mendapatkan value kelvin
    kelvin = (temperature + 459.67) / 1.8
    # varibale message digunakan untuk menampung hasil yang akan kembalikan
    # round digunakan untuk membuat value hanya memiliki 2 decimal
    message = f'-----Convert Suhu from Fahrenheit-----\nCelcius : {round(celcius, 2)}°C\nKelvin  : {round(kelvin, 2)}°K\nFahrenheit  : {round(temperature, 2)}°F\n'
    # mengembalikan message untuk di tampilkan
    return message
        

# Menggunakan data static dari variable
print(converter(21,'celcius'))      # Percobaan function converter dari Celcius
print(converter(304,'k'))           # Percobaan function converter dari Kelvin
print(converter(86,'f'))            # Percobaan function converter dari Fahrenheit
print(convertFahrenheit(32,'c'))    # Percobaan function convertFahrenheit
print(convertFromFahrenheit(77))    # Percobaan function convertFromFahrenheit


# Menggunakan data dinamis dari inputan user

# Function yang memiliki fungsi untuk menangkap inputan user dan menjalankan logic untuk men convert suhu
# Mengembalikan value status
def menuSatu(status):
    temp1 = checkTemperature()
    deg1 = checkDegree()
    print(converter(int(temp1),deg1))
    status = question(status)
    return status

# Function yang memiliki fungsi untuk menangkap inputan user dan menjalankan logic untuk men convert suhu ke fahrenheit
# Mengembalikan value status
def menuDua(status):
    temp2 = checkTemperature()
    deg2 = checkDegree()
    print(convertFahrenheit(int(temp2),deg2))
    status = question(status)
    return status

# Function yang memiliki fungsi untuk menangkap inputan user dan menjalankan logic untuk men convert suhu dari fahrenheit
# Mengembalikan value status
def menuTiga(status):
    temp3 = checkTemperature()
    print(convertFromFahrenheit(int(temp3)))
    status = question(status)
    return status

# Function yang memiliki fungsi untuk inputan user berupa pertanyaan akan lanjut atau selesai
# Mengembalikan value status
def question(status):
    # variable yang berfungsi sebagai flag untuk looping question
    answer = True
    # looping terus menerus jika value dari varible answer masih bernilai True
    while answer:
        done = input('Kembali ke menu?(Y/n) :')
        if done.lower() == 'y':
            status = True
            answer = False
        elif done.lower() == 'n':
            status = False
            answer = False
        else:
            print("Pilihan salah")
            answer = True
    return status

# Function yang digunakan untuk memastikan inputan temperature dari user
def checkTemperature():
    # variable yang berfungsi sebagai flag untuk looping inputan temperature
    notDigit = "Wrong"
    # looping terus menerus jika value dari varible notDigit masih bernilai True
    while notDigit.isdigit() == False:
        value = input("\nMasukan temperature: ")
        if value.isdigit() == False:
            print("Tolong Masukan number")
        else:
            return value

# Function yang digunakan untuk memastikan inputan satuan degree dari user
def checkDegree():
    # variable yang berfungsi sebagai flag untuk looping inputan degree
    check = True
    # looping terus menerus jika value dari varible check masih bernilai True
    while check:
        value = input("\nMasukan satuan suhu (C/Celcius, K/Kelvin, F/Fahrenheit): ")
        if value.lower() == 'c' or value.lower() == 'k' or value.lower() == 'f' or value.lower() == 'celcius' or value.lower() == 'kelvin' or value.lower() == 'fahrenheit':
            check = False
            return value
        else:
            print("Satuan suhu yang dimasukan salah")
            

# variable yang berfungsi sebagai flag untuk looping menu
status = True
# looping terus menerus jika value dari varible status masih bernilai True
while status:
    menu = "\nMenu\n1.Converter Suhu\n2.Converter from Fahrenheit\n3.Converter to Fahrenheit"
    print(menu)
    choice = input("Pilih Menu: ")
    if choice == '1':
        status = menuSatu(status)
    elif choice == '2':
        status = menuDua(status)
    elif choice == '3':
        status = menuTiga(status)
    else:
        print("Menu tidak ditemukan")