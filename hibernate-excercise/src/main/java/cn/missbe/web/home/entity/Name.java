package cn.missbe.web.home.entity;

import org.hibernate.annotations.Parent;

import javax.persistence.Column;
import javax.persistence.Embeddable;

/**
 * Created by Administrator on 2016/10/30 0030.
 */
@Embeddable
public class Name {
    @Column(name = "person_firstname")
    private  String first;
    @Column(name = "person_lastname")
    private  String last;
    @Parent
    private  Person owner;

//    @ElementCollection(targetClass = Integer.class)
//    @CollectionTable(name = "power_inf",
//            joinColumns = @JoinColumn(name = "person_name_id",nullable = false))
//    @MapKeyColumn(name = "name_aspect")
//    @Column(name = "name_power",nullable = false)
//    @MapKeyClass(String.class)
//    private Map<String,Integer> power=new HashMap<String,Integer>();

    public Name(){}
    public Name(String first,String last){
        this.first=first;
        this.last=last;
    }
//    public Map<String, Integer> getPower() {
//        return power;
//    }
//
//    public void setPower(Map<String, Integer> power) {
//        this.power = power;
//    }
    public String getFirst() {
        return first;
    }

    public void setFirst(String first) {
        this.first = first;
    }

    public String getLast() {
        return last;
    }

    public void setLast(String last) {
        this.last = last;
    }

    public Person getOwner() {
        return owner;
    }

    public void setOwner(Person owner) {
        this.owner = owner;
    }
}
