# Treasure Hunt Solver

Program sederhana berbasis GUI(Guide User Interface) yang dapat menggunakan BFS dan DFS untuk mendapatkan rute memperoleh seluruh harta karun

## Description

Program Treasure Hunt Solver mencari rute untuk memperoleh harta karun pada peta 2d \
([contoh peta](test/tc%20spek.txt))
* K menandakan titik awal
* T menandakan harta karun
* X menandakan grid halangan
* R menandakan grid yang dapat diakses

Program dapat mencari rute dengan:
1. Breadth First Search (BFS)
2. Depth First Search (DFS)

Program juga dapat mencari solusi Travelling Salesman Problem dengan:
1. Bruteforce
2. Dynamic Programming

## Getting Started

### Dependencies

* Windows 10/Windows 11
* .NET Core 7

### Build

* Clone this repository
* Open cmd from root folder
** Build only 
```
dotnet build src\WindowsFormsApp2
```
** Build and run
```
dotnet run --project src\WindowsFormsApp2
```

### Executing program

* Open cmd from root folder and type
```
bin\net7.0-windows\WindowsFormsApp2.exe
```

## Misc
### Warna visualisasi

Rute traversal divisualisasi dengan keterangan warna:
* Kuning menandakan grid sudah selesai diproses
* Biru menandakan grid sedang diproses

Rute akhir ditampilkan dengan keterangan warna:
* Kuning cerah menandakan grid dilewati sekali
* Kuning agak gelap menandakan grid dilewati dua kali
* Kuning lebih gelap menandakan grid dilewati tiga kali atau lebih

### Prioritas Traversal

Pada saat traversal, program selalu mencari path dengan prioritas:\
Left, Right, Up, Down\
[detail](src/WindowsFormsApp2/TraverseRule.cs)


## Authors

- [Yobel Dean Christopher](https://github.com/yobeldc) - 13521067
- [Michael Utama](https://github.com/Michaelu670) - 13521137
- [Dewana Gustavus Haraka Otang](https://github.com/DewanaGustavus) - 13521173

## Acknowledgments

* [double buffering winforms](https://www.kodesiana.com/post/mengatasi-lag-datagridview-csharp/)
* [color gradient generator](https://coolors.co/gradient-palette)

