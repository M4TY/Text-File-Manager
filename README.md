# Text-File-Manager
A simple to use library to read and write .txt files in C#. 

## Documentation
#### **string SeperateAllLines(string path, char separator)**
**Usage:** Loads all lines from a text file and merges it into a single line each word seperated with a character \
**Parameters:** string path - Path to the file you want to read from, char separator - is a character you want to split the words with. \

#### **string ReadSpecificLine(string path, int line)**
**Usage:** Returns contents of specific line in a .txt file \
**Parameters:** string path - Path to the file you want to read from, int line - line you want to read from. \

#### **int LinesCount(string path)**
**Usage:** Returns number of lines in a .txt file \
**Parameters:** string path - Path to the file you want to read from. \

#### **int LinesCount(string path)**
**Usage:** Returns number of lines in a .txt file \
**Parameters:** string path - Path to the file you want to read from. \

#### **bool DoesExist(string path)**
**Usage:** Checks if a file exists. \
**Parameters:** string path - Path to the file you want to read from. \

#### **void WriteArrayToFile(string path, string[] array)**
**Usage:** Takes your array and writes every index into a new line. \
**Parameters:** string path - Path to the file you want to read from, string[] array - String array you want converted to a text file. \

#### **void WriteValueToFile(string path, object value)**
**Usage:** Takes any variable and writes it into your text file. \
**Parameters:** string path - Path to the file you want to read from, object value - Any data type variable. \

# To-Do
- Nothing yet
