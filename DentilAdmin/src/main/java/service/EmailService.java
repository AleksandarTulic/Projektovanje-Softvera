package service;

import java.util.*;
import java.util.Map.Entry;
import java.util.logging.Level;

import javax.activation.DataHandler;
import javax.activation.DataSource;
import javax.activation.FileDataSource;
import javax.mail.BodyPart;
import javax.mail.Message;
import javax.mail.PasswordAuthentication;
import javax.mail.Session;
import javax.mail.Transport;
import javax.mail.internet.InternetAddress;
import javax.mail.internet.MimeBodyPart;
import javax.mail.internet.MimeMessage;
import javax.mail.internet.MimeMultipart;

import logger.MyLogger;

public class EmailService {
	private static final String EMAIL_FROM = "testingprogram99@gmail.com";
	private static final String EMAIL_FROM_PASSWORD = "";
	private static final String HOST = "smtp.gmail.com";
	private static final String Port = "587";
	
	@SuppressWarnings("serial")
	private static final Map<String, String> map = new HashMap<String, String>(){{
		put("mail.smtp.auth", "true");
		put("mail.smtp.starttls.enable", "true");
		put("mail.smtp.host", HOST);
		put("mail.smtp.port", Port);
	}};
	
	public boolean send(String email, String path) {
		Properties properties = new Properties();
		
		for (Entry<String, String> entry : map.entrySet()) {
			properties.put(entry.getKey(), entry.getValue());
		}
		
		Session session = Session.getInstance(properties,
        new javax.mail.Authenticator() {
			protected PasswordAuthentication getPasswordAuthentication() {
				return new PasswordAuthentication(EMAIL_FROM, EMAIL_FROM_PASSWORD);
			}
		});
		
		try {
			Message message = new MimeMessage(session);
			message.setFrom(new InternetAddress(EMAIL_FROM));
			message.setRecipients(Message.RecipientType.TO, InternetAddress.parse(email));
			message.setSubject("Dentil - Account Credentials");
			message.setText("This qr code is needed for login. \nUse the Google Authentication app for finding the value.");
			
			MimeMultipart multipart = new MimeMultipart("related");
			BodyPart messageBodyPart = new MimeBodyPart();
			String htmlText = "<H1>Hello</H1><p>This qr code is needed for login. <br>Use the Google Authentication app for finding the value.</p><img src=\"cid:image\">";
	        messageBodyPart.setContent(htmlText, "text/html");
	        multipart.addBodyPart(messageBodyPart);
	        messageBodyPart = new MimeBodyPart();
	        DataSource fds = new FileDataSource(path);
	        messageBodyPart.setDataHandler(new DataHandler(fds));
	        messageBodyPart.setHeader("Content-ID", "<image>");
	        multipart.addBodyPart(messageBodyPart);
	        message.setContent(multipart);
	        
			Transport.send(message);
			
			return true;
		}catch (Exception e) {
			MyLogger.logger.log(Level.SEVERE, e.getMessage());
		}
		
		return false;
	}
}
