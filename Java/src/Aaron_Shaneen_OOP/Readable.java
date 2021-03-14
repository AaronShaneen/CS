/*
 * Daniel Beus
 * IO Interfaces
 * To use with Ass 11
 */

package Aaron_Shaneen_OOP;

import java.io.FileNotFoundException;
import java.io.IOException;

public interface Readable
{
    public void Read(String path) throws FileNotFoundException, IOException;
}