<?xml version="1.0"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:template match="/">
		<html>
			<body>
				<h1>ForEach example</h1>
				<table>
					<tr>
						<th>First Name</th>
						<th>Last Name</th>
						<th>Email</th>
					</tr>
					<xsl:for-each select="ListEmployee/Employee">
						<tr>
							<td><xsl:value-of select="FirstName"/></td>
							<td><xsl:value-of select="LastName"/></td>
							<td><xsl:value-of select="E-Mail"/></td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template>	
</xsl:stylesheet>
