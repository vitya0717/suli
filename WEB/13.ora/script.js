/*Minden idők 100 legjobb klasszikus könyvét bemutató weboldalon legyenek statikus elemek is.(sztroi, egyéb tartalom..)
        100 könyv adatainak elérése (válasz másik módot, a múlt óraitól eltérő módon jelenjenek meg az adatok)
        Adathalmaz rendezése (a lapok száma szerint, és vagy megjelenés éve szerint)
        Keresés (nyelv szerint, szerző szerint, cím szerint)
        Új könyv hozzáadása, törlés, módosítás funkciókat valósítsd meg. 
        Lehet bootstrap, w3, vagy saját stílus vagy ezek kombinációja.*/
        class Konyv {
            constructor(id, author, country, imagelink, language, link, pages, title, year) {
                this.id = id;
                this.author = author;
                this.country = country;
                this.imagelink = imagelink;
                this.language = language;
                this.link = link;
                this.pages = pages;
                this.title = title;
                this.year = year;
            }
        }

        
        var konyvek = [];
        var id = 0;
        var bookCount;
        var cardlist;
        //Új könyv változók
        var author;
        var country;
        var imagelink;
        var language;
        var link;
        var pages;
        var title;
        var year;
        //üres könyv példány
        var newBook;
        //Módosítás
        var cauthor;
        var ccountry;
        var cimagelink;
        var clanguage;
        var clink;
        var cpages;
        var ctitle;
        var cyear;

        var conditions;
        var search_input;
        var searched = []
        var mult = Number('1');

        //var pattern = "https(:){1}//raw(.){1}githubusercontent(.){1}com(/){1}benoitvallon(/){1}100-best-books(/){1}master(/){1}static(/){1}images(/){1}[a-zA-Z0-9\-\]{1,254}.jpg";
        var pattern = "images(/){1}[a-zA-Z0-9\-\]{1,254}.jpg";
        window.onload = function () {
            fetch("https://raw.githubusercontent.com/benoitvallon/100-best-books/master/books.json")
                .then((response) => response.json())
                .then((json) => {
                    json.forEach(element => {
                        konyvek.push(new Konyv(id, element["author"], element["country"], element["imageLink"], element["language"], element["link"], element["pages"], element["title"], element["year"]));
                        id++;
                    });
                    bookCount = konyvek.length;
                    createCards(konyvek);
                    console.log("Újra lett generálva minden... sajna");
                });
            //author, country, imagelink, language, link, pages, title, year
            author = document.getElementById("new-author");
            author.value = "Putyin";
            country = document.getElementById("new-country");
            country.value = "Oroszország";
            imagelink = document.getElementById("new-imagelink");
            imagelink.value = "https://image.cnbcfm.com/api/v1/image/107170422-16717337232022-12-22t182143z_934003418_rc25by9yeknw_rtrmadp_0_ukraine-crisis-russia-putin.jpeg?v=1673966428";
            language = document.getElementById("new-langauage");
            language.value = "Orosz";
            link = document.getElementById("new-link");
            link.value = "www.google.ru";
            pages = document.getElementById("new-pages");
            pages.value = "60000";
            title = document.getElementById("new-title");
            title.value = "A nép szava";
            year = document.getElementById("new-year");
            year.value = "2024";

        }
        //Kártyák létrehozás
        function createCards(array) {
            cardlist = document.getElementById("card-list");
            cardlist.innerHTML = "";
            for (let i = 0; i < array.length; i++) {
                if (array[i] != undefined) {
                    const konyv = array[i];
                    const srcImg = konyv.imagelink.match(pattern) ? `${"https://raw.githubusercontent.com/benoitvallon/100-best-books/master/static/images/" + konyv.imagelink.split('/')[1]}` : konyv.imagelink;
                    cardlist.innerHTML +=
                        `<div id="${konyv.id}" class="col">
                            <div class="card h-100 brownBorder">
                            <img style="height: 75%;" src="${srcImg}" class="card-img-top"> 
                        <div class="card-body">
                            <h5 class="card-title">${konyv.author}</h5>
                            <p class="card-text">${konyv.title}</p>
                            <p class="card-text"><small class="text-muted">Megjelenés: ${konyv.year}</small></p>

                            <!-- Módosítás -->
                            <button id="${konyv.id}" onclick="loadChangeValues()" data-bs-toggle="modal" data-bs-target="#cardChange-${konyv.id}" class="btn btn-warning">Módosítás</button>

                            <div class="modal fade" id="cardChange-${konyv.id}" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                            <div class="modal-dialog" role="document">
                                <div class="modal-content">
                                <div class="modal-header">
                                    <h5 class="modal-title" id="exampleModalLabel">Módosítás</h5>
                                </div>
                                <div class="modal-body">
                                    <form>
                                    <div class="form-group">
                                        <!--Szerző-->
                                        <label for="cnew-author-cardChange-${konyv.id}" class="col-form-label">Szerző:</label>
                                        <input id="cnew-author-cardChange-${konyv.id}" type="text" class="form-control">
                                        <!--Ország-->
                                        <label for="cnew-country-cardChange-${konyv.id}" class="col-form-label">Ország:</label>
                                        <input id="cnew-country-cardChange-${konyv.id}" type="text" class="form-control" id="recipient-name">
                                        <!--Borítókép-->
                                        <label for="cnew-imagelink-cardChange-${konyv.id}" class="col-form-label">Borítókép(.png/.jpg link):</label>
                                        <input id="cnew-imagelink-cardChange-${konyv.id}" type="text" class="form-control" id="recipient-name">
                                        <!--Nyelv-->
                                        <label for="cnew-langauage-cardChange-${konyv.id}" class="col-form-label">Nyelv:</label>
                                        <input id="cnew-langauage-cardChange-${konyv.id}" type="text" class="form-control"  id="recipient-name">
                                        <!--Információ-->
                                        <label for="cnew-link-cardChange-${konyv.id}" class="col-form-label">Információs link(wiki):</label>
                                        <input id="cnew-link-cardChange-${konyv.id}" type="text" class="form-control"id="recipient-name">
                                        <!--Oldalszám-->
                                        <label for="cnew-pages-cardChange-${konyv.id}" class="col-form-label">Oldalszám:</label>
                                        <input id="cnew-pages-cardChange-${konyv.id}" type="text" class="form-control"id="recipient-name">
                                        <!--Címe-->
                                        <label for="cnew-title-cardChange-${konyv.id}" class="col-form-label">Címe:</label>
                                        <input id="cnew-title-cardChange-${konyv.id}" type="text" class="form-control" id="recipient-name">
                                        <!--Megjelenés éve-->
                                        <label for="cnew-year-cardChange-${konyv.id}" class="col-form-label">Megjelenés éve:</label>
                                        <input id="cnew-year-cardChange-${konyv.id}" type="text" class="form-control"id="recipient-name">
                                    </div>
                                    </form>
                                </div>
                                <div class="modal-footer">
                                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Mégsem</button>
                                    <button id="${konyv.id}" onclick="changeBook()" type="button" class="btn btn-success" data-bs-dismiss="modal">Módosítás mentése</button>
                                </div>
                                </div>
                            </div>
                            </div>

                            <!-- Törlés -->
                            <button class="btn btn-danger" data-bs-toggle="modal" data-bs-target="#cardRemove-${konyv.id}">Törlés</button>

                            <!-- Kártya törlés megerősítés ablak -->
                            <div class="modal fade" id="cardRemove-${konyv.id}" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
                            <div class="modal-dialog">
                                <div class="modal-content">
                                <div class="modal-header">
                                    <h5 class="modal-title" id="exampleModalLabel">Törlés megerősítése</h5>
                                </div>
                                <div class="modal-body">Biztosan törölni szeretnéd az adott elemet?</div>
                                <div class="modal-footer">
                                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Mégsem</button>
                                    <button id="${konyv.id}" onclick="removeBook()" type="button" class="btn btn-danger" data-bs-dismiss="modal">Törlés</button>
                                </div>
                                </div>
                            </div>
                            </div>
                            <!-- Információ -->
                            <button class="btn btn-info" data-bs-toggle="modal" data-bs-target="#cardInfo-${konyv.id}">Információ</button>

                            <!-- Információs ablak -->
                            <div class="modal fade" id="cardInfo-${konyv.id}" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
                            <div class="modal-dialog">
                                <div class="modal-content">
                                <div class="modal-header">
                                    <h5 class="modal-title" id="exampleModalLabel">${konyv.title}</h5>
                                </div>
                                <!--author, country, imagelink, language, link, pages, title, year-->
                                <div class="modal-body">
                                    A könyv címe: <b>${konyv.title}</b><br>
                                    A könyv szerzője: <b>${konyv.author}</b><br>
                                    A könyv származási helye: <b>${konyv.country}</b><br>
                                    A könyv nyelve: <b>${konyv.language}</b><br>
                                    Oldalak száma: <b>${konyv.pages}</b><br>
                                    Megjelenés éve: <b>${konyv.year}</b><br>
                                    Borítókép hivatkozás: <b>${konyv.imagelink}</b><br>
                                    A könyvről bővebben olvashat: <a target="_blank" href="${konyv.link}">${konyv.link}</a><br>
                                    </div>
                                <div class="modal-footer">
                                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Mégsem</button>
                                </div>
                                </div>
                            </div>
                            </div>

                        </div>
                    </div>
                    </div>`
                }
            }
        }
        //sort
        function sortBooks(type) {
            var sorted = [];
            if (type == "author") {
                sorted = konyvek.sort((a, b) => a.author > b.author ? mult : -mult);
                createCards(sorted);
                mult *= -1;
            } else if (type == "pages") {
                sorted = konyvek.sort((a, b) => a.pages > b.pages ? mult : -mult);
                createCards(sorted);
                mult *= -1;
            }else if (type == "year") {
                sorted = konyvek.sort((a, b) => a.year > b.year ? mult : -mult);
                createCards(sorted);
                
                mult *= -1;
            }
            document.getElementById("sortPages").innerHTML = mult == -1 ? "Oldalszám szerint(Növekvő)" : "Oldalszám szerint(Csökkenő)";
            document.getElementById("sortYears").innerHTML = mult == -1 ? "Évszám szerint(Növekvő)" : "Évszám szerint(Csökkenő)";
        }
        //
        function searchInAuthors() {
            searched = [];
            search_input = document.getElementById("searchInput");
            conditions = search_input.value.split(',');
            conditions.forEach(element => {
                konyvek.forEach(object => {
                    if(object.author.toLowerCase().includes(element)) {
                        if(!ArrayContainsBook(searched, object)) {
                            searched.push(object);
                        }    
                    }
                });
            });
        }
        //Keresés (nyelv szerint, szerző szerint, cím szerint)
        function searchBooks() {
            search_input = document.getElementById("searchInput");
            conditions = search_input.value.split(',');
            if (conditions.length == 1 && conditions[0] == '') { return createCards(konyvek); }
            searchInAuthors();
            createCards(searched);
        }
        var vane = false;
        function ArrayContainsBook(array, konyv) {
            array.forEach(ko => {
                if (ko.author == konyv.author &&
                    ko.country == konyv.country &&
                    ko.title == konyv.title) {
                    vane = true;
                }
            });
            return vane;
        }
        //Új könyv hozzáadás
        function addBook() {
            newBook = new Konyv(id, author.value, country.value, imagelink.value, language.value, link.value, pages.value, title.value, year.value);
            if (!ArrayContainsBook(konyvek, newBook)) {
                konyvek.push(newBook);
                id++;
                createCards(konyvek);
            }
        }
        //Könyv törlése
        function removeBook() {
            var book = document.getElementById(event.target.id);
            konyvek.forEach(konyv => {
                if (konyv.id != null) {
                    if (book.id == konyv.id) {
                        delete konyvek[konyvek.indexOf(konyv)];
                        bookCount--;
                        createCards(konyvek);
                    }
                }
            });
        }
        //Módosítás változók betöltése
        function loadChangeValues() {
            var id = event.target.id;
            cauthor = document.getElementById("cnew-author-cardChange-"+id);
            cauthor.value = konyvek[id].author;
            ccountry = document.getElementById("cnew-country-cardChange-"+id);
            ccountry.value = konyvek[id].country;
            cimagelink = document.getElementById("cnew-imagelink-cardChange-"+id);
            cimagelink.value = konyvek[id].imagelink;
            clanguage = document.getElementById("cnew-langauage-cardChange-"+id);
            clanguage.value = konyvek[id].language;
            clink = document.getElementById("cnew-link-cardChange-"+id);
            clink.value = konyvek[id].link;
            cpages = document.getElementById("cnew-pages-cardChange-"+id);
            cpages.value = konyvek[id].pages;
            ctitle = document.getElementById("cnew-title-cardChange-"+id);
            ctitle.value = konyvek[id].title;
            cyear = document.getElementById("cnew-year-cardChange-"+id);
            cyear.value = konyvek[id].year;
        }
        //Könyv módosítás
        function changeBook() {
            var changeBook = document.getElementById(event.target.id);
            if (ArrayContainsBook(konyvek, konyvek[changeBook.id])) {
                konyvek[changeBook.id].author = cauthor.value;
                konyvek[changeBook.id].country = ccountry.value;
                konyvek[changeBook.id].imagelink = cimagelink.value;
                konyvek[changeBook.id].language = clanguage.value;
                konyvek[changeBook.id].link = clink.value;
                konyvek[changeBook.id].pages = cpages.value;
                konyvek[changeBook.id].title = ctitle.value;
                konyvek[changeBook.id].year = cyear.value;
                createCards(konyvek);
            }
            console.log(ArrayContainsBook(konyvek, konyvek[changeBook.id]))
            console.log(changeBook.id);
        }

