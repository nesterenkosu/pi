<?xml version="1.0"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:template match="/ListEmployee">
		<html>
			<body>
				<table>
					<h1>IF samples</h1>
					<ul>
						<xsl:apply-templates select="Employee"/>
					</ul>
				</table>
			</body>
		</html>
	</xsl:template>
	
	<xsl:template match="Employee">
		<li>
			[<xsl:value-of select="position()"/>]
			<xsl:if test="position()=1">
				<b><xsl:value-of select="FirstName"/></b>
			</xsl:if>
			<xsl:if test="position()&gt; 1 and position()&lt; last()">
				<i><xsl:value-of select="FirstName"/></i>
			</xsl:if>
			<xsl:if test="position()=last()">
				<u><xsl:value-of select="FirstName"/></u>
			</xsl:if>
		</li>	
	</xsl:template>
</xsl:stylesheet>