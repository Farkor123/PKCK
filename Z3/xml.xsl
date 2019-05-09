<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
    <xsl:output method="xml" version="2.0" encoding="UTF-8" indent="yes"/>

    <xsl:template match="/">
        <xsl:element name="report">
            <xsl:element name="books">
                <xsl:for-each select="books/booksList/book">
                    <xsl:sort select="@id"/>
                    <xsl:element name="book">

                        <xsl:variable name="Writer" select="bookWriter/@id"/>
                        <xsl:variable name="Publisher" select="bookPublisher/@id"/>

                        <xsl:element name="ID">
                            <xsl:value-of select="@id"/>
                        </xsl:element>
                        <xsl:element name="bookTitle">
                            <xsl:value-of select="bookTitle"/>
                        </xsl:element>
                        <xsl:element name="bookIsbn">
                            <xsl:value-of select="bookIsbn"/>
                        </xsl:element>
                        <xsl:element name="bookDateOfPublish">
                            <xsl:value-of select="bookDateOfPublish"/>
                        </xsl:element>
                        <xsl:element name="bookPrice">
                            <xsl:value-of select="bookPrice"/>
                        </xsl:element>

                        <xsl:for-each select="../../../books/writersList/writer">
                            <xsl:variable name="writerId" select="@id"/>
                            <xsl:if test="$writerId = $Writer">
                                <xsl:element name="writerName">
                                    <xsl:value-of select="name"/>
                                </xsl:element>
                                <xsl:element name="writerSurname">
                                    <xsl:value-of select="surname"/>
                                </xsl:element>
                                <xsl:element name="writerBirthYear">
                                    <xsl:value-of select="writerBirthYear"/>
                                </xsl:element>
                            </xsl:if>
                        </xsl:for-each>

                        <xsl:for-each select="../../../books/publishersList/publisher">
                            <xsl:if test="$Publisher = @id">
                                <xsl:element name="publisherName">
                                    <xsl:value-of select="publisherName"/>
                                </xsl:element>
                            </xsl:if>
                        </xsl:for-each>
                    </xsl:element>
                </xsl:for-each>

            </xsl:element>


            <xsl:element name="stats">
                <xsl:variable name="booksNumber" select="count(books/booksList/book)"/>
                <xsl:variable name="bookPriceAVG" select="sum(books/booksList/book/bookPrice) div $booksNumber"/>
                <xsl:element name="bookNumber">
                    <xsl:value-of select="$booksNumber"/>
                </xsl:element>
                <xsl:element name="bookPriceAVG">
                    <xsl:value-of select="format-number($bookPriceAVG,'#.##')"/>
                </xsl:element>

                <xsl:element name="writerNumber">
                    <xsl:value-of select="count(books/writersList/writer)"/>
                </xsl:element>

                <xsl:element name="publisherNumber">
                    <xsl:value-of select="count(books/publishersList/publisher)"/>
                </xsl:element>

            </xsl:element>
        </xsl:element>
    </xsl:template>

</xsl:stylesheet>
