package HibDemo;

import javax.persistence.*;

@Entity(name="alien table")
public class Alien {
	
	@Id
	private Integer aid;
	@Transient
	private String aname;
	@Column(name="alienColor")
	private String acolor;
	
	public Integer getAid() {
		return aid;
	}
	public void setAid(Integer aid) {
		this.aid = aid;
	}
	public String getAname() {
		return aname;
	}
	public void setAname(String aname) {
		this.aname = aname;
	}
	public String getAcolor() {
		return acolor;
	}
	public void setAcolor(String acolor) {
		this.acolor = acolor;
	}
	
	

}
