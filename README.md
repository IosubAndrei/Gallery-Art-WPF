
# Gallery Art WPF 🎨  
O aplicație desktop dezvoltată în WPF pentru gestionarea și afișarea unei galerii de artă.  

## Descriere  
Gallery Art WPF este o aplicație dedicată pasionaților de artă, colecționarilor sau organizatorilor de expoziții. Proiectul oferă o platformă ușor de utilizat pentru administrarea și vizualizarea unei colecții de artă digitală.  

## Funcționalități  
- **Afișarea unei galerii de artă** – Vizualizează operele de artă într-o interfață prietenoasă și modernă.  
- **Gestionare opere de artă** – Adaugă, editează și șterge articole din colecție.  
- **Căutare și filtrare** – Găsește rapid operele dorite utilizând funcțiile integrate de căutare și filtrare.  
- **Persistența datelor** – Salvează informațiile despre operele de artă într-o bază de date SQL Server.  

## Tehnologii utilizate  
- **C# și WPF (Windows Presentation Foundation)** pentru dezvoltarea aplicației desktop.  
- **Entity Framework** pentru gestionarea bazei de date.  
- **XAML** pentru proiectarea interfeței grafice.  
- **SQL Server** pentru stocarea datelor.  

## Instalare și utilizare  
### 1. Clonează repository-ul  
```bash
git clone https://github.com/Roiul/Gallery-Art-WPF.git
```  

### 2. Configurarea bazei de date  
- Creează o nouă bază de date în SQL Server.  
- Actualizează string-ul de conexiune din fișierul `appsettings.json` sau în cod, conform detaliilor serverului SQL Server:  

### 3. Deschide soluția în Visual Studio  
- Asigură-te că toate pachetele necesare sunt restaurate utilizând `NuGet`.  

### 4. Rulează aplicația    

## Licență  
Acest proiect este licențiat sub [MIT License](LICENSE).  
