<?xml version="1.0" encoding="UTF-8" ?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
    <xsl:output method="html" version="1.0" encoding="UTF-8" indent="yes"/>
    <xsl:template match="/">
        <html lang="en">
            <head>
                <!-- Required meta tags -->
                <meta charset="utf-8"/>
                <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>

                <!-- Bootstrap CSS -->
                <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"
                      integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"
                      crossorigin="anonymous"/>

                <title>PKCK | zad3</title>
            </head>
            <body>
                <div class="container">
                    <div class="table-responsive">
                        <table class="table">
                            <caption>List of books</caption>
                            <thead>
                                <tr>
                                    <th scope="col">id</th>
                                    <th scope="col">Title</th>
                                    <th scope="col">ISBN</th>
                                    <th scope="col">Publication Date</th>
                                    <th scope="col">Price</th>
                                    <th scope="col">writer's name</th>
                                    <th scope="col">writer's surname</th>
                                    <th scope="col">writer's birth year</th>
                                    <th scope="col">publisher name</th>
                                </tr>
                            </thead>
                            <tbody>
                                <xsl:for-each select="report/books/book">
                                    <tr>
                                        <td><xsl:value-of select="ID"/></td>
                                        <td><xsl:value-of select="bookTitle"/></td>
                                        <td><xsl:value-of select="bookIsbn"/></td>
                                        <td><xsl:value-of select="bookDateOfPublish"/></td>
                                        <td><xsl:value-of select="bookPrice"/></td>
                                        <td><xsl:value-of select="writerName"/></td>
                                        <td><xsl:value-of select="writerSurname"/></td>
                                        <td><xsl:value-of select="writerBirthYear"/></td>
                                        <td><xsl:value-of select="publisherName"/></td>
                                    </tr>

                                </xsl:for-each>
                            </tbody>
                        </table>
                    </div>
                </div>

                <!-- Optional JavaScript -->
                <!-- jQuery first, then Popper.js, then Bootstrap JS -->
                <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"
                        integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN"
                        crossorigin="anonymous"></script>
                <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"
                        integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"
                        crossorigin="anonymous"></script>
                <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"
                        integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"
                        crossorigin="anonymous"></script>
            </body>
        </html>
    </xsl:template>

</xsl:stylesheet>
