UPDATE School
SET SchoolPicture = CONVERT(VarBinary(MAX),'C:\Users\Think\Downloads\preschool-kids-for-website-2.png') 
WHERE SchoolID < 10;