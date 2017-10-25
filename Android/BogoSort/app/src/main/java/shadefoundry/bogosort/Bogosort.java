package shadefoundry.bogosort;

import java.util.Collections;
import java.util.List;
import java.util.Iterator;

public class Bogosort {
    private static <T extends Comparable<? super T>> boolean isSorted(List<T> list) {
        if (list.isEmpty())
            return true;
        Iterator<T> it = list.iterator();
        T last = it.next();
        while (it.hasNext()) {
            T current = it.next();
            if (last.compareTo(current) > 0)
                return false;
            last = current;
        }
        return true;
    }

    public static <T extends Comparable<? super T>> int bogoSort(List<T> list) {
        int numShuffles = 0;
        while (!isSorted(list)){
            numShuffles+=1;
            Collections.shuffle(list);
        }
        return numShuffles;
    }
}