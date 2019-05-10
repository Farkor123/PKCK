<xsl:transform version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:template match="/">
        <svg width="1600px" height="900px" xmlns="http://www.w3.org/2000/svg">
            <g id="bar" transform="translate(0,200)">
                <xsl:for-each select="report/books/book">
                    <xsl:element name="text">
                        <xsl:value-of select="ID"/>
                    </xsl:element>

                </xsl:for-each>
            </g>
        </svg>
    </xsl:template>
</xsl:transform>