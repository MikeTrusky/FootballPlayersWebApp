# FootballPlayersWebApp
Web app made as part of learning ASP.NET technology

[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![LinkedIn][linkedin-shield]][linkedin-url]

<!-- PROJECT LOGO -->
<br />
<p align="center">
  <h2 align="center">Football players web app</h2>

</p>

<!-- TABLE OF CONTENTS -->
<details open="open">
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Installation</a></li>
      </ul>
    </li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgements">Acknowledgements</a></li>
  </ol>
</details>

<!-- ABOUT THE PROJECT -->
## About The Project

[![Football Players Web App screen][product-screenshot]](https://github.com/MikeTrusky/FootballPlayersWebApp)
[![Football Players Web App screen][product-screenshot-2]](https://github.com/MikeTrusky/FootballPlayersWebApp)
[![Football Players Web App screen][product-screenshot-3]](https://github.com/MikeTrusky/FootballPlayersWebApp)

The project was prepared as part of learning the ASP.NET. It is the begin of the web application.

What is included in the project:
* adding players to database
* searching for a player
* authentication - you have to be logged in to create new players or editing existing ones
* register and login

### Built With

* [VisualStudio2019](https://visualstudio.microsoft.com/pl/downloads/)
* [ASP.NET](https://dotnet.microsoft.com/apps/aspnet)

### Installation

To run project you have to: 
1. Clone the repo
  ```sh
  git clone https://github.com/MikeTrusky/FootballPlayersWebApp.git
  ```
2. Open Package Manager Console in Visual Studio
```
View->Package Manager Console
```
3. Update databases:
```First database
update-database -Context FootballPlayersWebAppContext
```
```Second database
update-database -Context ApplicationDbContext
```
In both updates you should get:
```
Build started...
Build succeeded.
Done.
```

<!-- CONTACT -->
## Contact

Maciej Trzuskowski - maciej.trzuskowski@gmail.com

Project Link: [FootballPlayersWebAppRepo](https://github.com/MikeTrusky/FootballPlayersWebApp)

<!-- ACKNOWLEDGEMENTS -->
## Acknowledgements
* [Img Shields](https://shields.io)
* [GitHub Pages](https://pages.github.com)
* [Othneil Drew Readme Template](https://github.com/othneildrew/Best-README-Template)

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/MikeTrusky/FootballPlayersWebApp.svg?style=for-the-badge
[contributors-url]: https://github.com/MikeTrusky/FootballPlayersWebApp/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/MikeTrusky/FootballPlayersWebApp.svg?style=for-the-badge
[forks-url]: https://github.com/MikeTrusky/FootballPlayersWebApp/network/members
[stars-shield]: https://img.shields.io/github/stars/MikeTrusky/FootballPlayersWebApp.svg?style=for-the-badge
[stars-url]: https://github.com/MikeTrusky/FootballPlayersWebApp/stargazers
[issues-shield]: https://img.shields.io/github/issues/MikeTrusky/FootballPlayersWebApp.svg?style=for-the-badge
[issues-url]: https://github.com/MikeTrusky/FootballPlayersWebApp/issues
[license-shield]: https://img.shields.io/github/license/MikeTrusky/FootballPlayersWebApp.svg?style=for-the-badge
[license-url]: https://github.com/MikeTrusky/FootballPlayersWebApp/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/maciej-trzuskowski-245b78202/
[product-screenshot]: Screens/FootballersList.png
[product-screenshot-2]: Screens/Searching.png
[product-screenshot-3]: Screens/Register.png
