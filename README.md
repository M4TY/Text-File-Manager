# Text-File-Manager
Simple to use library to read and write .txt files in C#.<br/>

## Documentation
#### **string SeperateAllLines(string path, char separator)**<br/>
**Usage:** Loads all lines from a text file and merges them into a single line with each word seperated with a character. Returns a sentence.<br/>
**Parameters:** string path - Path to the file you want to read from, char separator - is a character you want to split the words with.<br/>

-------------------------------------------------------------------------------------------------------------------------

#### **string ReadSpecificLine(string path, int line)**<br/>
**Usage:** Returns contents of specific line in a .txt file.<br/> 
**Parameters:** string path - Path to the file you want to read from, int line - line you want to read from.<br/>

-------------------------------------------------------------------------------------------------------------------------

#### **int LinesCount(string path)**<br/>
**Usage:** Returns number of lines in a .txt file.<br/>
**Parameters:** string path - Path to the file you want to read from.<br/>

-------------------------------------------------------------------------------------------------------------------------

#### **int LinesCount(string path)**<br/>
**Usage:** Returns integer of lines in a .txt file.<br/>
**Parameters:** string path - Path to the file you want to read from.<br/>

-------------------------------------------------------------------------------------------------------------------------

#### **bool DoesExist(string path)**<br/>
**Usage:** Checks if a file exists.<br/>
**Parameters:** string path - Path to the file you want to read from.<br/>

-------------------------------------------------------------------------------------------------------------------------

#### **void WriteArrayToFile(string path, string[] array)**<br/>
**Usage:** Takes your array and writes every index into a new line.<br/>
**Parameters:** string path - Path to the file you want to read from, string[] array - String array you want converted into a text file.<br/>

-------------------------------------------------------------------------------------------------------------------------

#### **void WriteValueToFile(string path, object value)**<br/>
**Usage:** Takes any variable and writes it into your text file.<br/>
**Parameters:** string path - Path to the file you want to read from, object value - Any data type variable.<br/>

-------------------------------------------------------------------------------------------------------------------------

#### **void CreateFile(string name)**<br/>
**Usage:** Creates a file with specified name.<br/>
**Parameters:** string name - a string that describes the name of your file .<br/>

-------------------------------------------------------------------------------------------------------------------------

# To-Do<br/>
- [X] Improve documentation<br/>
- [ ] Add more methods<br/>
