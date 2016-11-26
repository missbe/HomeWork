package cn.missbe;

/**
 * Created by Administrator on 2016/11/10 0010.
 */
public class Main {

    public static void main(String[] args){
        int array[]={1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23};

//        System.out.println("Result:"+algorithm.BinarySearch1(array,20,array.length))
//        System.out.println("Result:"+algorithm.BinarySearch4(array,20,array.length));
//          System.out.println("Result:"+algorithm.BinarySearch7(array,23,array.length));

        Position p=algorithm.BinarySearch0(array,12,array.length);
        System.out.println("Result-Left:"+p.getI()+" Right:"+p.getJ());

    }
}
