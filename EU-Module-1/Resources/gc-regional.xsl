<?xml version="1.0" encoding="iso-8859-1" standalone="no"?>

<!--
	GCC Module 1 Style-Sheet

	Version 2.3
	20 october 2015
	add submission-unit
	add some values iin submission

	1 October 2012 (v2.1)
	replacement of alcohol-free by alcohol-content and pork-free by pork-content
	samples (change in specific)
-->
<xsl:stylesheet version="1.0"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
	xmlns:gc="http://sfda.gov.sa" 
	xmlns:xlink="http://www.w3c.org/1999/xlink">
   <xsl:output method="html" encoding="UTF-8" indent="no"/>
   <xsl:template match="/">
      <html>
         <head>
            <title>GCC Module 1 - DTD version <xsl:value-of select="/gc:gc-backbone/@dtd-version"/></title>
            <style type="text/css">
				h1, h2, h3, h4 {margin-top:3pt ; margin-bottom:0pt}
				ul {margin-bottom:0pt ; margin-top:0pt}
			</style>
         </head>
			<body>
				<center>
					<h1>GCC Module 1</h1>
					<small>DTD version <xsl:value-of select="/gc:gc-backbone/@dtd-version"/></small>
				</center>
				<xsl:apply-templates select="//envelope"/>
				<br/>
				<xsl:apply-templates select="//m1-gc"/>
			</body>
		</html>
	</xsl:template>
	
	<xsl:template match="*|@*" mode="data">
		<xsl:value-of select="."/>
	</xsl:template>
	
	<xsl:template match="*|@*" mode="country">
		<xsl:value-of select="translate(.,'abcdefghijklmnopqrstuvwxyz', 'ABCDEFGHIJKLMNOPQRSTUVWXYZ')"/>
	</xsl:template>
	
	<xsl:template match="*|@*" mode="csv">
		<xsl:value-of select="."/>
		<xsl:if test="position() != last()"><xsl:text>, </xsl:text></xsl:if>
	</xsl:template>
	
	<xsl:template match="*|@*" mode="agency">
		<xsl:choose>
			<xsl:when test="@code='AE-MOH'">UAE - Ministry of Health</xsl:when>
			<xsl:when test="@code='BH-MOH'">BAHRAIN - Ministry of Health</xsl:when>
			<xsl:when test="@code='KW-MOH'">KUWAIT - Ministry of Health</xsl:when>
			<xsl:when test="@code='OM-MOH'">OMAN - Ministry of Health</xsl:when>
			<xsl:when test="@code='QA-NHA'">QATAR - National Health Authority</xsl:when>
			<xsl:when test="@code='SA-SFDA'">KSA  - Saudi Food &amp; Drug Authority</xsl:when>
			<xsl:when test="@code='YE-MOPHP'">Republic of Yemen - Ministry of Public Health &amp; and Population</xsl:when>
		</xsl:choose>
		<xsl:text> </xsl:text>(<xsl:value-of select="@code"/>)
	</xsl:template>
	
	<xsl:template match="*|@*" mode="submission">
		<xsl:choose>
			<xsl:when test="@type='asmf'">Active Substance Master File</xsl:when>
			<xsl:when test="@type='extension'">Line Extension</xsl:when>
			<xsl:when test="@type='pmf'">Plasma Master File</xsl:when>
			<xsl:when test="@type='new-nce'">New Marketing Authorization Application - New chemical entity</xsl:when>
			<xsl:when test="@type='new-bio'">New Marketing Authorization Application - Biological Products</xsl:when>
			<xsl:when test="@type='new-rad'">New Marketing Authorization Application - Radiopharmaceuticals</xsl:when>
			<xsl:when test="@type='none'">None</xsl:when>
			<xsl:when test="@type='new-gen'">New Marketing Authorization Application - Generics</xsl:when>
			<xsl:when test="@type='var-type1'">Variation Type I</xsl:when>
			<xsl:when test="@type='var-type2'">Variation Type II</xsl:when>
			<xsl:when test="@type='psur'">Periodic Safety Update Report</xsl:when>
			<xsl:when test="@type='psusa'">PSUR Single Assessment procedure</xsl:when>
			<xsl:when test="@type='rmp'">Risk Management Plan</xsl:when>
			<xsl:when test="@type='transfer-ma'">Transfer of a Marketing Authorization</xsl:when>
			<xsl:when test="@type='renewal'">Renewal (Yearly or 5-Yearly)</xsl:when>
			<xsl:when test="@type='withdrawal'">Withdrawal during assessment or withdrawal of a marketing authorization</xsl:when>
			<xsl:when test="@type='usr'">Urgent Safety Restriction</xsl:when>
		</xsl:choose>
	</xsl:template>
	
	<xsl:template match="*|@*" mode="submission-unit">
		<xsl:choose>
			<xsl:when test="@type='initial'">Initial submission to start the regulatory activity</xsl:when>
			<xsl:when test="@type='response'">Response to any kind of question, validation issues out-standing information</xsl:when>
			<xsl:when test="@type='additional-info'">Other additional Information </xsl:when>
			<xsl:when test="@type='closing'">Provision of the final documents</xsl:when>
			<xsl:when test="@type='correction'">Correction to the published annexes in GCC</xsl:when>
			<xsl:when test="@type='reformat'">Reformatting of an existing submission application from any format to eCTD</xsl:when>
		</xsl:choose>
	</xsl:template>
	
	<xsl:template match="*|@*" mode="procedure">
		<xsl:choose>
			<xsl:when test="@type='gcc'">GCC Procedure</xsl:when>
			<xsl:when test="@type='national'">National Procedure</xsl:when>
		</xsl:choose>
	</xsl:template>

	<xsl:template match="*|@*" mode="pidoc-type">
		<xsl:choose>
			<xsl:when test="@type='spc'">Summary of Product Characteristics (SPC)</xsl:when>
			<xsl:when test="@type='label'">Labeling</xsl:when>
			<xsl:when test="@type='pil'">Patient Information Leaflet</xsl:when>
		</xsl:choose>
	</xsl:template>
	
	<xsl:template match="envelope">
		<center>
			<table width="90%" border="1px" frame="border" rules="groups" cellpadding="2" cellspacing="0">
				<tr>
					<td colspan="2"><h3>Envelope for <xsl:apply-templates select="./@country" mode="country"/></h3></td>
				</tr>
				<tr>
					<td width="20%">Application Reference Number: </td>
					<td><xsl:apply-templates select="application/number" mode="csv"/></td>
				</tr>
				<tr>
					<td>Applicant: </td>
					<td><xsl:apply-templates select="applicant" mode="data"/></td>
				</tr>
				<tr>
					<td>Agency: </td>
					<td><xsl:apply-templates select="agency" mode="agency"/></td>
				</tr>
				<tr>
					<td>ATC: </td>
					<td><xsl:apply-templates select="atc" mode="csv"/></td>
				</tr>
				<tr>
					<td>Submission: </td>
					<td><xsl:apply-templates select="submission" mode="submission"/></td>
				</tr>
				<tr>
					<td>Submission unit: </td>
					<td><xsl:apply-templates select="submission-unit" mode="submission-unit"/></td>
				</tr>
				<tr>
					<td>Procedure: </td>
					<td><xsl:apply-templates select="procedure" mode="procedure"/></td>
				</tr>
				<tr>
					<td>Invented Name: </td>
					<td><xsl:apply-templates select="invented-name" mode="csv"/></td>
				</tr>
				<tr>
					<td>INN: </td>
					<td><xsl:apply-templates select="inn" mode="csv"/></td>
				</tr>
				<tr>
					<td>Sequence: </td>
					<td><xsl:apply-templates select="sequence" mode="data"/></td>
				</tr>
				<tr>
					<td>Related Sequence: </td>
					<td><xsl:apply-templates select="related-sequence" mode="csv"/></td>
				</tr>
				<tr>
					<td>Submission Description: </td>
					<td><xsl:apply-templates select="submission-description" mode="data"/></td>
				</tr>
			</table>
		</center>
	</xsl:template>

	<xsl:template match="specific">
		For <xsl:apply-templates select="./@country" mode="country"/>: 
		<ul type="square">
			<xsl:apply-templates select="leaf | node-extension"/>
		</ul>
	</xsl:template>
	
	<xsl:template name="pi-doc-row">
		<xsl:param name="ctry"/>
		<tr>
			<td align="center"><xsl:apply-templates select="$ctry" mode="country"/></td>
			<td><xsl:apply-templates select="//pi-doc[./@country=$ctry and @type='spc']/leaf" mode="plain"/><br/></td>
			<td><xsl:apply-templates select="//pi-doc[./@country=$ctry and @type='label']/leaf" mode="plain"/><br/></td>
			<td><xsl:apply-templates select="//pi-doc[./@country=$ctry and @type='pil']/leaf" mode="plain"/><br/></td>
		</tr>
	</xsl:template>
	
	<xsl:template match="pi-doc">
		<xsl:variable name="pos" select="position()"/>
		<xsl:variable name="ctry" select="./@country"/>
		
		<xsl:variable name="prev" select="count(//pi-doc[position() &lt; $pos and @country = $ctry])"/>
		<xsl:if test="$prev = 0">
			<xsl:call-template name="pi-doc-row">
				<xsl:with-param name="ctry" select="$ctry"/>
			</xsl:call-template>
		</xsl:if>
	</xsl:template>
	
	<xsl:template match="leaf" mode="plain">
		<a>
			<xsl:attribute name="href"><xsl:value-of select="@xlink:href"/></xsl:attribute>
			<xsl:value-of select="title"/>
		</a>
		<xsl:text> </xsl:text>
		(<font color="red"><xsl:value-of select="@operation"/></font> - <font color="green"><xsl:value-of select="../@xml:lang"/></font>)
		<xsl:if test="position() != last()"><br/></xsl:if>
	</xsl:template>
	
	<xsl:template match="leaf">
		<li>
			<a>
				<xsl:attribute name="href"><xsl:value-of select="@xlink:href"/></xsl:attribute>
				<xsl:value-of select="title"/>
			</a>
			<xsl:text> </xsl:text>
			(<font color="red"><xsl:value-of select="@operation"/></font>)
			<xsl:if test="position() != last()"><br/></xsl:if>
		</li>
	</xsl:template>	
	
	<xsl:template match="node-extension">
		<li><xsl:apply-templates select="title" mode="data"/>
			<ul type="square">
				<xsl:apply-templates select="leaf | node-extension"/>
			</ul>
		</li>
	</xsl:template>

	<xsl:template match="m1-3-1-spc">
		<table width="100%" cellpadding="2" cellspacing="0" border="1" style="font-size: 9pt">
			<tr>
				<th width="05%">Country</th>
				<th width="11%">1.3.1 SPC</th>
				<th width="11%">1.3.2 Labeling</th>
				<th width="11%">1.3.3 Patient Information Leaflet (PIL)</th>
			</tr>
			<xsl:apply-templates select="pi-doc"/>
		</table>
	</xsl:template>

	<xsl:template match="m1-gc">
		<center>
			<table width="90%" cellpadding="5" cellspacing="2">
				<tr>
					<td colspan="2"><h2>Module 1</h2></td>
				</tr>
				<tr>
					<td width="5%" valign="top"><h3>1.0</h3></td>
					<td width="95%">
						<h3>Cover Letter</h3>
						<xsl:apply-templates select="m1-0-cover/specific"/>
					</td>
				</tr>
				<tr>
					<td valign="top"><h3>1.2</h3></td>
					<td>
						<h3>Application Form</h3>
						<xsl:apply-templates select="m1-2-form/specific"/>
					</td>
				</tr>
				<tr>
					<td valign="top"><h3>1.3</h3></td>
					<td>
						<h3>Product Information</h3>
					</td>
				</tr>

				<tr>
					<td valign="top"><h4></h4></td>
					<td>
						<h4>Summary of Product Characteristics, Labeling, Leaflet</h4>
						<xsl:apply-templates select="m1-3-pi/m1-3-1-spc"/>
					</td>
				</tr>
				

				<tr>
					<td valign="top"><h4>1.3.4</h4></td>
					<td>
						<h4>Artwork</h4>
						<ul type="square">
							<xsl:apply-templates select="m1-3-pi/m1-3-4-mockup/specific"/>
						</ul>
					</td>
				</tr>

				<tr>
					<td valign="top"><h4>1.3.5</h4></td>
					<td>
						<h4>Samples</h4>
						<ul type="square">
							<xsl:apply-templates select="m1-3-pi/m1-3-5-samples/specific"/>
						</ul>
					</td>
				</tr>

				<tr>
					<td valign="top"><h3>1.4</h3></td>
					<td>
						<h3>Information on the Experts</h3>
					</td>
				</tr>
				<tr>
					<td valign="top"><h4>1.4.1</h4></td>
					<td>
						<h4>Quality</h4>
						<ul type="square">
							<xsl:apply-templates select="m1-4-expert/m1-4-1-quality/leaf | m1-4-expert/m1-4-1-quality/node-extension"/>
						</ul>
					</td>
				</tr>
				<tr>
					<td valign="top"><h4>1.4.2</h4></td>
					<td>
						<h4>Non-Clinical</h4>
						<ul type="square">
							<xsl:apply-templates select="m1-4-expert/m1-4-2-non-clinical/leaf | m1-4-expert/m1-4-2-non-clinical/node-extension"/>
						</ul>
					</td>
				</tr>
				<tr>
					<td valign="top"><h4>1.4.3</h4></td>
					<td>
						<h4>Clinical</h4>
						<ul type="square">
							<xsl:apply-templates select="m1-4-expert/m1-4-3-clinical/leaf | m1-4-expert/m1-4-3-clinical/node-extension"/>
						</ul>
					</td>
				</tr>
					
				<tr>
					<td valign="top"><h3>1.5</h3></td>
					<td>
						<h3>Environmental Risk Assessment</h3>
					</td>
				</tr>
				<tr>
					<td valign="top"><h4>1.5.1</h4></td>
					<td>
						<h4>Non-GMO</h4>
						<ul type="square">
							<xsl:apply-templates select="m1-5-environrisk/m1-5-1-non-gmo/leaf | m1-5-environrisk/m1-5-1-non-gmo/node-extension"/>
						</ul>
					</td>
				</tr>
				<tr>
					<td valign="top"><h4>1.5.2</h4></td>
					<td>
						<h4>GMO</h4>
						<ul type="square">
							<xsl:apply-templates select="m1-5-environrisk/m1-5-2-gmo/leaf | m1-5-environrisk/m1-5-2-gmo/node-extension"/>
						</ul>
					</td>
				</tr>
			
				<tr>
					<td valign="top"><h3>1.6</h3></td>
					<td>
						<h3>Pharmacovigilance</h3>
					</td>
				</tr>
				<tr>
					<td valign="top"><h4>1.6.1</h4></td>
					<td>
						<h4>Pharmacovigilance System</h4>
						<ul type="square">
							<xsl:apply-templates select="m1-6-pharmacovigilance/m1-6-1-pharmacovigilance-system/leaf | m1-6-pharmacovigilance/m1-6-1-pharmacovigilance-system/node-extension"/>
						</ul>
					</td>
				</tr>
				<tr>
					<td valign="top"><h4>1.6.2</h4></td>
					<td>
						<h4>Risk-management Plan</h4>
						<ul type="square">
							<xsl:apply-templates select="m1-6-pharmacovigilance/m1-6-2-risk-management-system/leaf | m1-6-pharmacovigilance/m1-8-2-risk-management-system/node-extension"/>
						</ul>
					</td>
				</tr>
				
				<tr>
					<td valign="top"><h3>1.7</h3></td>
					<td>
						<h3>Certificates and Documents</h3>
					</td>
				</tr>
				<tr>
					<td valign="top"><h4>1.7.1</h4></td>
					<td>
						<h4>GMP Certificate</h4>
						<ul type="square">
					<xsl:apply-templates select="m1-7-certificates/m1-7-1-gmp/leaf | m1-7-certificates/m1-7-1-gmp/node-extension"/>
						</ul>
					</td>
				</tr>


				<tr>
					<td valign="top"><h4>1.7.2</h4></td>
					<td>
						<h4>Certificate of Pharmaceutical Product or Free sales</h4>
						<ul type="square">
		<xsl:apply-templates select="m1-7-certificates/m1-7-2-cpp/leaf | m1-7-certificates/m1-7-2-cpp/node-extension"/>
						</ul>
					</td>
				</tr>



				<tr>
					<td valign="top"><h4>1.7.3</h4></td>
					<td>
						<h4>Certificate of analysis - Drug Substance/Finished Product</h4>
						<ul type="square">
		<xsl:apply-templates select="m1-7-certificates/m1-7-3-analysis-substance/leaf | m1-7-certificates/m1-7-3-analysis-substance/node-extension"/>
						</ul>
					</td>
				</tr>

				<tr>
					<td valign="top"><h4>1.7.4</h4></td>
					<td>
						<h4>Certificate of analysis - Excipients</h4>
						<ul type="square">
					<xsl:apply-templates select="m1-7-certificates/m1-7-4-analysis-excipients/leaf | m1-7-certificates/m1-7-4-analysis-excipients/node-extension"/>
						</ul>
					</td>
				</tr>
				<tr>
					<td valign="top"><h4>1.7.5</h4></td>
					<td>
						<h4>Alcohol-content declaration</h4>
						<ul type="square">
		<xsl:apply-templates select="m1-7-certificates/m1-7-5-alcohol-content/leaf | m1-7-certificates/m1-7-5-alcohol-content/node-extension"/>
						</ul>
					</td>
				</tr>
				
				<tr>
					<td valign="top"><h4>1.7.6</h4></td>
					<td>
						<h4>Pork-content declaration</h4>
						<ul type="square">
					<xsl:apply-templates select="m1-7-certificates/m1-7-6-pork-content/leaf | m1-7-certificates/m1-7-6-pork-content/node-extension"/>
						</ul>
					</td>
				</tr>


			<tr>
					<td valign="top"><h4>1.7.7</h4></td>
					<td>
						<h4>Certificate of suitability for TSE</h4>
						<ul type="square">
					<xsl:apply-templates select="m1-7-certificates/m1-7-7-certificate-tse/leaf | m1-7-certificates/m1-7-7-certificate-tse/node-extension"/>
						</ul>
					</td>
				</tr>


				<tr>
					<td valign="top"><h4>1.7.8</h4></td>
					<td>
						<h4>The diluents and coloring agents in the product formula</h4>
						<ul type="square">
		<xsl:apply-templates select="m1-7-certificates/m1-7-8-diluent-coloring-agents/leaf | m1-7-certificates/m1-7-8-diluent-coloring-agents/node-extension"/>
						</ul>
					</td>
				</tr>
		
				<tr>
					<td valign="top"><h4>1.7.9</h4></td>
					<td>
						<h4>Patent Information</h4>
						<ul type="square">
		<xsl:apply-templates select="m1-7-certificates/m1-7-9-patent-information/leaf | m1-7-certificates/m1-7-9-patent-information/node-extension"/>
						</ul>
					</td>
				</tr>
				

<tr>
			<td valign="top"><h4>1.7.10</h4></td>
					<td>
						<h4>Letter of access or acknowledgment to DMF</h4>
						<ul type="square">
		<xsl:apply-templates select="m1-7-certificates/m1-7-10-letter-access-dmf/leaf | m1-7-certificates/m1-7-10-letter-access-dmf/node-extension"/>
						</ul>
					</td>
				</tr>

				<tr>
					<td valign="top"><h3>1.8</h3></td>
					<td>
						<h3>Pricing</h3>
					</td>
				</tr>
				<tr>
					<td valign="top"><h4>1.8.1</h4></td>
					<td>
						<h4>Price List</h4>
						<ul type="square">
					<xsl:apply-templates select="m1-8-pricing/m1-8-1-price-list/leaf | m1-8-pricing/m1-8-1-price-list/node-extension"/>
						</ul>
					</td>
				</tr>

				<tr>
					<td valign="top"><h4>1.8.2</h4></td>
					<td>
						<h4>Other documents related</h4>
						<ul type="square">
					<xsl:apply-templates select="m1-8-pricing/m1-8-2-other-document/leaf | m1-8-pricing/m1-8-2-other-document/node-extension"/>
						</ul>
					</td>
				</tr>

				<tr>
					<td valign="top"><h3>1.9</h3></td>
					<td>
						<h3>Responses to Questions</h3>
						<xsl:apply-templates select="m1-9-responses/specific"/>
					</td>
				</tr>
				<tr>
					<td valign="top"><h3></h3></td>
					<td>
						<h3>Additional Data</h3>
						<xsl:apply-templates select="m1-additional-data/specific"/>
					</td>
				</tr>
			</table>
		</center>
	</xsl:template>
	
</xsl:stylesheet>
