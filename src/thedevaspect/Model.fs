type Details= {
    Name:  string
    Description: string}

type Item ={
    Details: Details}

type Exit= 
    | PassableExist of Details * destination: Room
    | LockedExist of Details  * key: Item * next: Exit
    | NoExist of Details option

and Exits= {
    North:  Exit
    South:  Exit
    West:  Exit
    East:  Exit}

and Room ={
    Details: Details
    Items: Item list
    Exists: Exits}

let firstRoom =
    {Details = { Name= "First Room"; Description="You're stangding on a room'"};
    Items = [];
    Exists = 
        {
        North=  NoExist(None);
        South=  NoExist(None);
        West=  NoExist(None);
        East=  NoExist(None)}}
