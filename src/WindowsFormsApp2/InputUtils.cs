using System;


namespace WindowsFormsApp2
{
    public class InputUtils
    {
        public string[] lines {get;set;}
        public char[ , ] matrix {get;set;}
        public bool[ , , ] canMove {get;set;}
        public Pair<int, int>[] treasureCoordinate {get;set;}
        public Pair<int,int> startCoordinate {get;set;}
        public int row {get;set;}
        public int col {get;set;}

        // ctor
        public InputUtils(string filePath){
            lines = File.ReadAllLines(filePath);

            bool validInput = InputValidator();
            if(validInput){
                row = lines.Length;
                col = lines[0].Split(' ').Length;

                char[ , ] tmpMatrix = new char[row,col];
                for(int i = 0; i < lines.Length; i++){
                    string[] values = lines[i].Split(' ');
                    for(int j = 0; j < values.Length; j++){
                        tmpMatrix[i][j] = values[j];
                    }
                }
                matrix = tmpMatrix;
            }else{
                throw new Exception("Input tidak sesuai format");
            }
            
            startCoordinate = calculateStartCoordinate();
            treasureCoordinate = calculateTreasureCoordinate();
            canMove = calculateCanMove();

            // ? gak tau yang kurang apa di flag dulu
        }

        // validasi input file
        private bool InputValidator(){
            string[] validSymbol = {"K", "T", "R", "X"};
            bool validInput = true; // ? kita perlu cek semua treasure reachable kah?, cek treasure minimal 1 kah?
            int kCount = 0;
            int tmpCol = lines[0].Split(' ').Length;
            
            for(int i = 0; i < lines.Length; i++){
                string[] values = lines[i].Split(' ');
                if(values.Length != tmpCol){
                    // jumlah kolom gak sama
                    validInput = false;
                }

                for(int j = 0; j < values.Length; j++){
                    if(!Array.contain(validSymbol, values[j])){
                        // kalau input gak ada di validSymbol berarti invalid
                        validInput = false;
                    }
                    if(values[j] == "K")kCount++;
                }
            }

            if(kCount != 1){
                // kalau starting point bukan 1 (bisa lebih, bisa 0), input gak valid
                validInput = false;
            }
            return validInput;
        }

        // bool[row][col][{L,R,U,D}] bisa jalan ke arah situ gak dari koordinat yang dikasih
        private bool[ , , ] calculateCanMove(){
            canMove = new bool [row, col, 4];
            for(int i=0;i<row;i++){
                for(int j=0;j<col;j++){
                    // L
                    if(j == 0 || matrix[i][j-1] == 'X')canMove[i][j][0] = false;
                    else canMove[i][j][0] = true;

                    // R
                    if(j == col-1 || matrix[i][j+1] == 'X')canMove[i][j][1] = false;
                    else canMove[i][j][1] = true;
                    
                    // U
                    if(i == 0 || matrix[i-1][j] == 'X')canMove[i][j][2] = false;
                    else canMove[i][j][2] = true;
                    
                    // D
                    if(i == row-1 || matrix[i+1][j] == 'X')canMove[i][j][3] = false;
                    else canMove[i][j][3] = true;
                
                }
            }
        }

        // mengeluarkan kumpulan koordinat dari treasure
        private Pair<int, int>[] calculateTreasureCoordinate(){
            // ? mungkin bisa di improve pake dynamic array, tapi gini aja udah aman
            int tCount = 0;
            for(int i = 0; i < row; i++){
                for(int j = 0; j < col; j++){
                    if(matrix[i][j] == 'T'){
                        tCount++;
                    }
                }
            }

            Pair<int, int>[] coordinate = new Pair<int, int>[tCount];
            int currentIndex = 0;
            for(int i = 0; i < row; i++){
                for(int j = 0; j < col; j++){
                    if(matrix[i][j] == 'T'){
                        coordinate[currentIndex++] = new Pair<int, int>(row, col);
                    }
                }
            }
            return coordinate;
        }

        // mengeluarkan koordinat awal pada treasure hunt
        private Pair<int,int> calculateStartCoordinate(){
            int rowCoordinate;
            int colCoordinate;
            for(int i = 0; i < row; i++){
                for(int j = 0; j < col; j++){
                    if(matrix[i][j] == 'K'){
                        rowCoordinate = i;
                        colCoordinate = j;
                    }
                }
            }

            return new Pair<int, int> (rowCoordinate, colCoordinate); 
        }
    }
}
