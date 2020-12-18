<?xml version="1.0"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:template match="/ListEmployee">
		<html>
			<body>
				<h1>Ordering inside template</h1>
				<table>
					<tr>
						<th>First Name</th>
						<th>Last Name</th>
						<th>Email</th>
					</tr>
					<xsl:apply-templates>
						<xsl:sort select="FirstName" order="descending"/>
						<xsl:sort select="LasrName" order="descending"/>						
					</xsl:apply-templates>
				</table>
			</body>
		</html>
	</xsl:template>
	
	<xsl:template match="Employee">
		<tr>
			<td><xsl:value-of select="FirstName"/></td>
			<td><xsl:value-of select="LastName"/></td>
			<td><xsl:value-of select="E-Mail"/></td>
		</tr>
	</xsl:template>
</xsl:stylesheet>