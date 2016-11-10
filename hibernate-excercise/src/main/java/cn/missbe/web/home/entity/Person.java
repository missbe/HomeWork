package cn.missbe.web.home.entity;

import javax.persistence.*;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * Created by Administrator on 2016/10/29 0029.
 */
@Entity
@Table(name="person_inf")
public class Person{
    @Id
    @Column(name="perosn_id")
    @GeneratedValue(strategy=GenerationType.IDENTITY)
    // 标识属性
    private Integer id;
//    private String name;
    private int age;
    @Enumerated(EnumType.ORDINAL)
    @Column(name = "happen_season")
    private Season happenSeason;

    @ElementCollection(targetClass = Score.class)
    @CollectionTable(name = "score_inf",joinColumns = @JoinColumn(name = "person_id",nullable = false))
    @MapKeyColumn(name = "subject_name")
    @MapKeyClass(String.class)
    private Map<String,Score> scores    =new HashMap<String, Score>();
    @ElementCollection(targetClass = Name.class)
    @CollectionTable(name="nick_inf",joinColumns = @JoinColumn(name="person_id",nullable = false))
    @OrderColumn(name = "list_order")
    private List<Name> nicks            =new ArrayList<Name>();
//    private Name name;
//    // 集合属性，保留该对象关联的学校
//    @ElementCollection(targetClass=String.class)
//    // 映射保存集合属性的表
//    @CollectionTable(name="school_inf", // 指定表名为school_inf
//            joinColumns=@JoinColumn(name="person_id" , nullable=false))
//    // 指定保存集合元素的列为 school_name
//    @Column(name="school_name")
//    // 映射集合元素索引的列
//    @OrderColumn(name="list_order")
//    private List<String> schools    = new ArrayList<String>();

    public enum Season{
        SPRING,SUMMER,AUTUMN,WINTER
    }

    public Season getHappenSeason() {
        return happenSeason;
    }

    public void setHappenSeason(Season happenSeason) {
        this.happenSeason = happenSeason;
    }
    public Map<String, Score> getScores() {
        return scores;
    }

    public void setScores(Map<String, Score> scores) {
        this.scores = scores;
    }

    public List<Name> getNicks() {
        return nicks;
    }

    public void setNicks(List<Name> nicks) {
        this.nicks = nicks;
    }
//    public Name getName() {
//        return name;
//    }
//
//    public void setName(Name name) {
//        this.name = name;
//    }

    // id的setter和getter方法
    public void setId(Integer id)
    {
        this.id = id;
    }
    public Integer getId()
    {
        return this.id;
    }

//    // name的setter和getter方法
//    public void setName(String name)
//    {
//        this.name = name;
//    }
//    public String getName()
//    {
//        return this.name;
//    }

    // age的setter和getter方法
    public void setAge(int age)
    {
        this.age = age;
    }
    public int getAge()
    {
        return this.age;
    }

    // schools的setter和getter方法
//    public void setSchools(List<String> schools)
//    {
//        this.schools = schools;
//    }
//    public List<String> getSchools()
//    {
//        return this.schools;
//    }
}